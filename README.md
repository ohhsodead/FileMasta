<h1 align="center">
  <img src="/WebPlex/Resources/logo.png" height="128" width="128" alt="Logo" />
  <br />
  WebPlex
</h1>

<h3 align="center">Search the web for videos, audios, eBooks and much more </h3>
<div align="center">
</div>
<br />

## What is WebPlex?
WebPlex is intended to provide a very powerful web server indexing and search service allowing you to find a file among millions of files located on public servers around the internet. 

The search engine is powered by a [database](https://dl.dropbox.com/s/ucyeqfn96x7n9lh/open-files.json?dl=0) that holds information about all the files web servers have. The information about the files is gathered by an intelligent web crawler that runs every 2 to 4 days. It keeps the database clean and up-to-date with the previous contents and new entries for each web server address submitted by members. 

All web addresses this app uses for indexing are submitted by users only, our crawler also try to give more priority to the servers that are most accessed via the website, if a web server isn't checked successfully in a period of time, usually 10-15 days, it is automatically deleted from our database. A list of the servers we index are stored in our [open directories](https://github.com/invu/WebPlex/blob/master/api/open-directories.txt). Also please check our [Terms of Use](https://github.com/invu/WebPlex/blob/master/TERMSOFUSE.md) statement for more information about what you have to take into consideration to use this application.

We host no content, we provide only access to already available files in a same way Google and other search engines do.

To contact the application owner and administrator you can send an e-mail to this address: bettercodes1@gmail.com, any comments or suggestions are welcome too, Thank you.

## Some Features Available
 * User-friendly interface with searches at lightning speed
 * Multilingual support - contributions are welcome!
 * Discover direct download links for almost anything!
 * Filter files by format, host and sort alphabetically
 * Search external search engines for directories/files
 * Find movies by name, actor, year and genre
 * Collects metadeta from public APIs
 * Embedded VLC Media Player
 * Support for other players (WMP, MPC & VLC)
 * Automatic local cache updates

## Latest Build
WebPlex 2.14.4

## Supported Systems
* Windows 7 and above (Windows 7, 8, 8.1, 10) using .NET 4.7.1 [Download here](https://www.microsoft.com/net/download/dotnet-framework-runtime/net471).

## Installation
Download and run the latest version of the Windows installer, "WebPlex.Installer.Windows.exe" from the [releases](https://github.com/invu/WebPlex/releases/latest) page.

## Creating an issue
Please supply as much information about the problem you are experiencing as possible. Your issue has a much greater chance of being resolved if logs are supplied so that we can see what is going on. Creating an issue with '### isn't working' doesn't help anyone to fix the problem.

## Contributing
All contributions are welcome just send a pull request. WebPlex's directory database allows our team (and any other volunteering dev) to implement new indexers in a few seconds. If you'd like support for a new indexer but are not a developer then feel free to leave a request on the [issues page](https://github.com/invu/webplex/issues). It is recommended to use Visual Studio 2017 when making code changes in this project. You can download the community version for free [here](https://www.visualstudio.com/downloads/).

## Frequently Asked Questions
<details>
<summary>Is this application secure?</summary>
<br>
Yes. All communications between our servers and your client is 100% secure.
</details>
<br>
<details>
<summary>How do you handle my privacy?</summary>
<br>
We don't use cookies, store sessions, userid's or IP addresses. See our <a href="https://github.com/invu/WebPlex/blob/master/PRIVACYPOLICY.md">Privacy Policy</a> for more information. 
</details>
<br>
<details>
<summary>I have found the files I need, but I cannot download them, the link does not work. Why?</summary>
<br>
None of the file links you can find on this app is located on current server, so this can happen very frequently.
<br>
There could be several reasons for that:

 * These files were recently removed from the server they were located, by the owner of the server or by someone else in the case of public servers.
 * The server that contains the files has a limit of maximum number of concurrent users logged in, and the limit has been reached. You can try to download the files later when some users disconnect or better still you should use a download manager that keeps trying to download the file.
 * The server where the files are is turned off or is not connected to the Internet at the moment.
 * The owner of the server has put a restriction on downloading these files.
 * Take a look at the age column on search results page, this represents the last time the indexer saw the file on the server, so the more recent, the more probable the file is available to download.
</details>
<br>
<details>
<summary>How can I download files from WebPlex? Do I need an special program?</summary>
<br>
You don't need a special program but it is very recommended. For example if you just click on the file link from your browser you can't see what is happening exactly between you and the web server (see previous question). So I would recommend to use a good web client that supports queuing or your favorite download manager, when you located the file you want to download just copy the shortcut by right clicking on the link and paste it on your web client or whatever, that its.</details>

## Prerequisites
- [Material Design Icons (Powered by Google)](https://materialdesignicons.com/)
- [CButton for .NET](https://www.codeproject.com/Articles/26622/Custom-Button-Control-with-Gradient-Colors-and-Ext)
- [Open Movie Database API](https://omdbapi.com)
- [Popcorn Time API](https://popcorntime.sh/)
- [YTS.AG (.am) API](https://yts.am/)
- [FileChef.com Top Searches](https://filechef.com/searches)
- [Json.NET (Newtonsoft)](https://newtonsoft.com/json)
- [VLC Player](https://videolan.org/vlc/)

## Screenshots
### Home
![Home](https://github.com/invu/WebPlex/blob/master/Screenshots/Home.png?raw=true)

### Movies
![Movies](https://github.com/invu/WebPlex/blob/master/Screenshots/Movies.png?raw=true)

### Movie Details
![Movie Details](https://github.com/invu/WebPlex/blob/master/Screenshots/Movie%20Details.png?raw=true)

### Files
![Files](https://github.com/invu/WebPlex/blob/master/Screenshots/Files.png?raw=true)

### File Details
![File Details](https://github.com/invu/WebPlex/blob/master/Screenshots/File%20Details.png?raw=true)
