// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
//  Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace VisualObjects.Common
{
    using System;
    using System.Collections.Concurrent;
    using System.Threading;

    public class VisualObjectsBox : IVisualObjectsBox
    {
        private readonly ConcurrentDictionary<string, string> objectData;
        private readonly ConcurrentDictionary<string, Timer> expiryTimers;
        private readonly TimeSpan expiryInterval;
        private readonly Timer refreshTimer;
        private string currentJson;

        public VisualObjectsBox()
            : this(Timeout.InfiniteTimeSpan, TimeSpan.FromMilliseconds(10))
        {
        }

        public VisualObjectsBox(TimeSpan expiryInterval, TimeSpan refreshInterval)
        {
            this.expiryInterval = expiryInterval;
            if (expiryInterval != Timeout.InfiniteTimeSpan)
            {
                this.expiryTimers = new ConcurrentDictionary<string, Timer>();
            }
            else
            {
                this.expiryTimers = null;
            }

            this.objectData = new ConcurrentDictionary<string, string>();
            this.currentJson = "[]";
            this.refreshTimer = new Timer(
                new TimerCallback(this.RefreshJson), 
                null, 
                refreshInterval, 
                refreshInterval);
        }

        string IVisualObjectsBox.GetJson()
        {
            return this.currentJson;
        }

        void IVisualObjectsBox.SetObject(string objectId, string objectJson)
        {
            if (this.expiryTimers != null)
            {
                if (this.expiryTimers.TryGetValue(objectId, out Timer expiryTimer))
                {
                    ExtendExpiryTimer(expiryTimer);
                }
                else
                {
                    this.expiryTimers.AddOrUpdate(objectId,
                        this.CreateExpiryTimer(objectId),
                        (i, t) => ExtendExpiryTimer(t));
                }
            }

            this.objectData[objectId] = "{\"id\":\"" + objectId + "\", \"node\":" + objectJson + "}";
        }

        private void RemoveObject(string objectId)
        {
            if (this.expiryTimers != null)
            {
                this.expiryTimers.TryRemove(objectId, out Timer timer);
            }

            this.objectData.TryRemove(objectId, out string objectJson);
        }

        private Timer ExtendExpiryTimer(Timer t)
        {
            t.Change(expiryInterval, Timeout.InfiniteTimeSpan);
            return t;
        }

        private void OnObjectExpired(object state)
        {
            string objectId = (string)state;
            RemoveObject(objectId);
        }

        private void RefreshJson(object state)
        {
            if (this.objectData.Keys.Count > 0)
            {
                this.currentJson = "[" + String.Join(",", this.objectData.Values) + "]";
            }
            else
            {
                this.currentJson = "[]";
            }
        }

        private Timer CreateExpiryTimer(string objectId)
        {
            return new Timer(
                new TimerCallback(OnObjectExpired),
                objectId,
                this.expiryInterval,
                Timeout.InfiniteTimeSpan);
        }
    }
}
