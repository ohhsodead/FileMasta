## 0.2.16.0
- Improved performance and stability
- Improved search function, much faster and returns more results
- Bug fixes


## 0.2.15.3
- Cleaned up code, a lot
- Improved sorting and overall functionality
- Improved file details panel
- Merged home search and external search engines button
- Improved web crawler to support most servers


## 0.2.15.2
- Updated UI
- Scroll through search results in the details page
- Added five randomly-generated recently added files to Home tab
- Re-added external search engines
- Changed file categories
- Fixed issue causing Bookmarks not loading if one was no longer in the database
- Removed languages, working on something easier for implementing new languages
- Various improvements to code
- Major fixes and improvements to web crawler


## 0.2.15.1
- Updates to the user interface
- Improved performance and overall stability
- Added auto updater (beta)
- Increased overall number of top searches shown
- Removed external search engines, we're working on a multiple search option instead
- Renamed 'Saved' files to 'Bookmarked' files
- Fixed some minor bugs, including #81 and #82


## 0.2.15.0
- Refurbished the entire UI (user interface)
- Enhanced functionality and performance
- Improved app logging, using log4net now
- Added sort files by size (#79) and date added
- Fixed bugs


## 0.2.14.8
- UI fixes
- Web crawler database improvements
- Several bug fixes


## 0.2.14.7
- Improved UI responsiveness
- Overall back-end code improvements
- Added several data validations, as well as default variables
- Fixed #68, #69, #70, #71, #74, #75
- Deflated Installer for quicker downloads
- Added support for Windows XP, Vista and Servers (2008-2012) to the Installer


## 0.2.14.6
- Renamed project to WebCrunch


## 0.2.14.5
- Somewhat responsive UI, to-do: consistency
- Various code improvements
- Fixed #65, #66 (null values caused by DateTime)


## 0.2.14.4
- Fixed total database file size


## 0.2.14.3
- Improved UI, smoother and consistent (dark elements)
- Added Custom* Files section to search for specific file types
- Added 'Loading stuck?' button to splash screen, workaround for long startups (#64)
- Added search time in seconds
- Renamed 'About' tab to 'Information'
- Several bug fixes


## 0.2.14.2
- Improvements UI elements
- Added core database info
- Fixed popup dialog not showing in parent form
- Fixed total indexed files size


## 0.2.14.1
- Added Files/Directories/Database stats
- Added latest database update date
- Added external search engines
- Added Privacy Policy
- Added Terms of Use
- Added Change Log
- Fixed #63, (temporarily) #62 


## 0.2.14.0
- Improved form/button UI consistency
- Added Home tab
- Added Top Search Results (Powered by FileChef.com)
- Added Share project on Facebook/Twitter
- Moved latest version text to DropBox


## 0.2.13.0
- Added localization strings
- Bug fixes


## 0.2.12.2
- Fixed Stream Info UI


## 0.2.12.1
- Some minor bug fixes


## 0.2.12.0
- UI/Database improvements (Now only one core database)
- Added Czech language (#53 Thanks to @Martin005)
- Added Discover tab
- Added All Files tab
- Added Other Files tab
- Added Saved Files tab (pathRoot / saved-files.json)
- Added Play Media button
- Added Submit tab, we're in-need of more sources
- Added DMCA report info
- Removed Filter Files by Format


## 0.2.11.0
- UI improvements
- Localization fixes (Thanks to @Martin005)
- Added file details page
- Added request file size button
- Added report poor quality template
- Removed download client, was unstable
- Removed bookmarks, working on something very similar


## 0.2.10.0
- Added video, audio and eBooks tab, replacing movies, series and anime
- Added size and date to file metadeta
- Other bug fixes and updates


## 0.2.9.3
- Fixed #48, again


## 0.2.9.2
- Fixed #47, #48, #50, #51
- Internal VLC reference fixes


## 0.2.9.1
- Fix README.md
- Forgot to uncomment database download


## 0.2.9.0
- Improved file details, now adds related files
- Added drop and drop local files
- Added search for similar files button
- Added background worker for bookmarks
- Added Popcorn Time magnets/torrents
- Fixed spinner not showing constantly
- Fixed not showing fan-art for random movie
- Fixed #44
- Cleaned up project files


## 0.2.8.2
- Added German language
- Fixed logging unhandled exceptions
- Other minor fixes


## 0.2.8.1
- Added YIFY API (yts.am) for Torrents/Magnets
- Bug fixes


## 0.2.8.0
- Optimised images further (Thanks to @StarSparkleNova)
- Uncaught exceptions writes to log file (Thanks to @badrazizi)
- Revised local database updates
- Improved stability during several processes
- Added French and Spanish languages
- Supports local files (must be in Downloads directory)
- Handles no Internet connection detected before startup
- Improved search result criteria for files
- Bookmark fixes
- Other minor bug fixes


## 0.2.7.0
- UI changes
- Added random movie button
- Added share file button
- Trailer now opens in default web browser
- Fixed displaying backgrounds for file
- Some download fixes


## 0.2.0.6
- UI/Icons enhancements (Thanks @google)
- Added support for archive files (.zip/.rar)
- Added support for loading subtitles in VLC (external player only, file names must match)
- Added catch download errors and retry button
- Added trailer button
- Added remaining download time
- Added file size and added date to media details
- Added copy file URL to clipboard
- Added internal VLC player (wip, supports basic streaming)
- Added Settings - #30
- Added verify downloaded files by comparing info
- Various back-end improvements, cleaned up code
- Fixed bookmark issues
- Database adjustments and fixes
- Download protocol fixes


## 0.2.0.5
- UI improvements
- Optimized resources to lossless compression
- Added bookmarks
- Added filter files by format, host and quality
- Added sort files alphabetically
- Fixed search results
- Other bug fixes


## 0.2.0.4
- Renamed project
- New and simpler file databases, uses open directories (file db updated manually by me)
- Support for filtering movies by year
- Support for series, subtitles, torrents and anime files
- Added Spinner for loading posters
- Catch unhandled exceptions
- Various bug fixes


## 0.2.0.3
- Enabled search box and filter by genre
- Fixed some issues with Json
- Other minor fixes


## 0.2.0.2
- Added background worker, thanks to @badrazizi
- Added file extension to datagrid
- Added support for opening stream in MPC
- Hidden search features for Movies, temporarily (working on fixes)
- Fixed loading bugs


## 0.2.0.1
- Asynchronous tasks and threads, highest performance rate yet
- Improved UI design
- Enabled maximize form
- Added Downloads tab, instead of window
- Added Report Broken button to streams
- Fixed some bugs


## 0.2.0.0
- Many UI changes
- Added splash screen
- Added background tasks and threads
- Added Movies tab for posters
- Added filter by genre, more coming soon
- Added search movies by people and year
- Added support for local cache, updates every 12 hours
- Added support for multiple streams
- Removed Report Broken source button, for now


## 0.1.0.4
- Tidied search results in dataGridView, displays host and file name
- Search box focus after adding tag
- Added report broken file button, pre-fills new issue
- Removed auto updater, now uses the Installer


## 0.1.0.3
- Added auto updater, somewhat works
- Removed Settings tab, lack of options (need some requests)
- Updated database changes and production data fixes
- Other various improvements


## 0.1.0.2
- UI improvements
- Added support for extracting movie from file name (format e.g. title year pixelsize format formatsize filename extension)
- Added movie details tab
- Added Trailer button
- Added OMDb API
- Added Popcorn Time API
- Added report issue button to about tab
- Added current version to about tab
- Added Cancel/Close button on download item
- Added support for drag and drop files
- Added copy links to clipboard
- Added Settings tab
- Improved search results
- Various bug fixes


## 0.1.0.1
- UI improvements
- Added download client
- Added support for multiple tags
- Added random backgrounds
- Added some popular tags for queries
- Added about tab
- Added support for opening URL in external players (Windows Media Player & VLC)


## 0.1.0.0
- Initial release
