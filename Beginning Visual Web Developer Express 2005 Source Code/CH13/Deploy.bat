XCOPY C:\temp\Deploy\web.config C:\Deploy
XCOPY C:\temp\Deploy\Default.aspx C:\Deploy
XCOPY C:\temp\Deploy\PreCompiledApp.config C:\Deploy
md C:\Deploy\bin
XCOPY C:\temp\Deploy\bin\*.dll C:\Deploy\bin
XCOPY C:\temp\Deploy\bin\*.compiled C:\Deploy\bin