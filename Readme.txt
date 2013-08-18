This is an C#/F# version of the Space War game we (Matthew Watson and David Emmerson) wrote
a long time ago in Pascal.

Setting up a development environment
1) Install Visual Studio 2010 (so XNA Game Studio will install)

2) Install Visual Studio 2012 (cause that's what the solution will open in).

3) For Windows 8 install only you will need to have installed of Games for Windows Marketplace before step 3 will succeed: 
http://www.xbox.com/en-US/LIVE/PC/DownloadClient)

4) Install XNA GameStudio 4
http://www.microsoft.com/en-us/download/details.aspx?id=23714

5) Install MonoGame (3.0.1)

6) Install OpenAl. MonoGame puts the installer here by default C:\Program Files (x86)\MonoGame\v3.0\oalinst.exe

7) Copy the XNA Game Extension from VS2010 to VS2012:
From: C:\Program Files (x86)\Microsoft Visual Studio 10.0\Common7\IDE\Extensions\Microsoft\XNA Game Studio 4.0
To C:\Program Files (x86)\Microsoft Visual Studio 11.0\Common7\IDE\Extensions\Microsoft\XNA Game Studio 4.0

8) Edit the extension.vsixmanifest file and change the <VisualStudio Version=10.0> tag to 11.0. I had to grant myself modify permissions on this file.

9) You may have to run the command to tell Visual Studio that new extensions are available. If you see an 'access denied' message, try launching the console as an administrator. 
	"C:\Program Files (x86)\Microsoft Visual Studio 11.0\Common7\IDE\devenv.exe" /setup
