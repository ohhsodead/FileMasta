# FileMasta

A federated search application for discovering interesting files that are being shared online, such as video, music, books, software, games, subtitles and much more. All data is crawled by [od-database](https://github.com/simon987/od-database) which collects information about the contents of servers worldwide. We don't search file contents.

![FileMasta](https://github.com/HerbL27/FileMasta/blob/master/screenshot1.png?raw=true)

>We host no content, we provide only access to already available files in the same way Google and other search engines do.

## Installation
Download and run the latest version of the installer from the [releases](https://github.com/mostlyash/FileMasta/releases/latest) page.

## Issues & Contributions
If you find a bug or have a feature request, please [create an issue](https://github.com/mostlyash/FileMasta/issues/new).

Contributions are highly welcome, however, except for very small changes, kindly file an issue and let's have a discussion before you open a pull request.

## Frequently Asked Questions
### Is this application secure?
Yes. All communications between our servers (Using Dropbox & GitHub) and your client is 100% secure. No other connections are made to severs where the files are hosted, unless they're chosen to be downloaded. 

### How do you handle my privacy?
We don't use cookies, store sessions, userid's or IP addresses.

### I have found the files I need, but I cannot download them, the link does not work. Why?
There could be several reasons for that:
* These files were recently removed from the server they were located, by the owner of the files or by the owner of the server. 
* The server that contains the files has a limit of maximum number of concurrent users, and the limit has been reached. You can try to download the files later when some users are disconnected. 
* The server where the files are is turned off or is not connected to the Internet at the moment.
* The owner of the server has put a restriction on downloading these files.

### How can I download files from FileMasta? Do I need any special program?
You don't need a special program but it is very recommended. For example, if you just open the link in your web browser you can't see what is happening exactly between you and the web server (see previous question). So I would recommend to use a good web client that supports queuing or your favorite download manager, when you located the file you want to download just copy the link and paste it in your web client or whatever, that's it.

## Resources
* [FileChef](https://filechef.com/searches)
* [log4net](https://logging.apache.org/log4net/)

## License
This project is licensed under the General Public License v3.