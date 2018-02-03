<h1 align="center">
  <img src="/WebCrunch/Resources/new_logo.png" height="128" width="128" alt="Logo" />
  <br />
  WebCrunch
</h1>

<h3 align="center">Search the web for videos, audios, eBooks and much more </h3>
<div align="center">
</div>
<br />

## What is WebCrunch?
WebCrunch is intended to provide a very powerful web server indexing and search service allowing you to find a file among millions of files located on public servers around the internet. 

The search engine is powered by a [database](https://dl.dropbox.com/s/ucyeqfn96x7n9lh/open-files.json?dl=0) that holds information about all the files web servers have. The information about the files is gathered by an intelligent web crawler that runs every 2 to 4 days. It keeps the database clean and up-to-date with the previous contents and new entries for each web server address submitted by members. 

All web addresses this app uses for indexing are submitted by users only, our crawler also try to give more priority to the servers that have the most up-time, if a web server isn't checked successfully in a period of time, usually 10-15 days, it is automatically deleted from our database. A list of the servers we index are stored in our [open directories](https://github.com/ekkash/WebCrunch/blob/master/api/open-directories.txt). Also please check our [Terms of Use](https://github.com/ekkash/WebCrunch/blob/master/TERMSOFUSE.md) statement for more information about what you have to take into consideration to use this application.

We host no content, we provide only access to already available files in a same way Google and other search engines do.

[![Report a bug](http://i.imgur.com/xSpw482.png)](https://github.com/ekkash/WebCrunch/issues/new) [![Feature request](http://i.imgur.com/mFO0OuX.png)](http://feathub.com/ekkash/WebCrunch)

## Latest Build
WebCrunch 2.15.1

## Supported Systems
* Windows XP and above (Windows XP, Vista, 7, 8, 8.1, 10) using .NET 4.7.1 [Download here](https://www.microsoft.com/net/download/dotnet-framework-runtime/net471).

## Installation
Download and run the latest version of the Windows installer, "WebCrunch.Installer.Windows.exe" from the [releases](https://github.com/ekkash/WebCrunch/releases/latest) page.

## Creating an Issue
Please supply as much information about the problem you are experiencing as possible. Your issue has a much greater chance of being resolved if logs are supplied so that we can see what is going on. Creating an issue with '### isn't working' doesn't help anyone to fix the problem.

## Contributing
All contributions are welcome just send a pull request. WebCrunch's directory database allows our team (and any other volunteering dev) to implement new indexers in a few seconds. If you'd like support for a new indexer but are not a developer then feel free to leave a request on the [issues page](https://github.com/ekkash/WebCrunch/issues). It is recommended to use Visual Studio 2017 when making code changes in this project. You can download the community version for free [here](https://www.visualstudio.com/downloads/).

## Frequently Asked Questions
<details>
<summary>Is this application secure?</summary>
<br>
Yes. All communications between our servers (FYI, we use Dropbox and GitHub) and your client is 100% secure.
</details>
<br>
<details>
<summary>How do you handle my privacy?</summary>
<br>
We don't use cookies, store sessions, userid's or IP addresses. See our <a href="https://github.com/ekkash/WebCrunch/blob/master/PRIVACYPOLICY.md">Privacy Policy</a> for more information. 
</details>
<br>
<details>
<summary>I have found the files I need, but I cannot download them, the link does not work. Why?</summary>
<br>
None of the file links you can find on this app is located on current server, so this can happen very frequently.
<br>
There could be several reasons for that:

 * These files were recently removed from the server they were located, by the owner of the server or by someone else in the case of public servers.
 * The server where the files are is turned off or is not connected to the Internet at the moment.
 * The owner of the server has put a restriction on downloading these files.
</details>
<br>
<details>
<summary>How can I download files from WebCrunch? Do I need any special program?</summary>
<br>
You don't need a special program but it is very recommended. For example, if you just open the link in your web browser you can't see what is happening exactly between you and the web server (see previous question). So I would recommend to use a good web client that supports queuing or your favorite download manager, when you located the file you want to download just copy the link and paste it in your web client or whatever, that's it.</details>

## Prerequisites
- [Material Design Icons (Powered by Google)](https://materialdesignicons.com/)
- [CButton for .NET](https://www.codeproject.com/Articles/26622/Custom-Button-Control-with-Gradient-Colors-and-Ext)
- [FileChef.com Top Searches](https://filechef.com/searches)
- [Json.NET (Newtonsoft)](https://newtonsoft.com/json)
- [VLC Player](https://videolan.org/vlc/)
- [log4net](https://logging.apache.org/log4net/)

## Screenshots
### 🏡 Home
![Home](https://github.com/ekkash/WebCrunch/blob/master/Screenshots/Home.png?raw=true)

### 🔎 Search Files
![Files](https://github.com/ekkash/WebCrunch/blob/master/Screenshots/Files.png?raw=true)

### 📂 File Details
![File Details](https://github.com/ekkash/WebCrunch/blob/master/Screenshots/File%20Details.png?raw=true)
