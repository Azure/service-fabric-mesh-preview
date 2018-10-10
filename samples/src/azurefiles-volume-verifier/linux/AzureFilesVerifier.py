import sys
f = open('/VolumeTest/Data/data.txt', 'r+')
content = f.read()
num = int(content)
if num > 5:
    f.truncate(0)
    f.seek(0)
    f.write("0")
    f.close()
    while True:
        continue
else:
    sys.exit(-1)
