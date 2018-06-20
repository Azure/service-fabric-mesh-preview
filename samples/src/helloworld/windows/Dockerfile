FROM microsoft/iis:windowsservercore-ltsc2016

RUN mkdir C:\site

RUN powershell -NoProfile -Command \
    Import-module IISAdministration; \
    Remove-WebSite -Name 'Default Web Site'; \
    New-IISSite -Name "Site" -PhysicalPath C:\site -BindingInformation "*:80:"

EXPOSE 80

ADD . /site
