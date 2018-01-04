# Contribute your links to OpenTheatre

## Open Directories
The *open-directories.txt* file is a list of every website/domain crawled by OpenTheatre ready to be discovered. To add links, edit the file and add your link to a new line somewhere, click 'Commit' and we'll verify the request as soon as we can. All files will be available upon our next automatic scan by the robots crawler.

- Only open directory links are allowed e.g. *https://domain.com/* or *https://domain.com/public/*
- No site listings under multiple domain names
- Do not submit incomplete or "Under Construction" web sites
- Do not use URL shorteners in order to submit multiple similar links
- No links to anything pornographic or in extremely bad taste

## Movie Posters
The *movie-posters.txt* is our Json format only file. Each item must be include the following attributes:

| Attribute | Type | Description | Example |
| --- | --- | --- | --- |
| id | string | An http://imdb.com movie id | *tt1431045* |
| sources | string array | Available direct file links for the movie | *http://hostname.com/movies/Deadpool.2016.720p.BluRay.H264.AAC-RARBG/Deadpool.2016.720p.BluRay.H264.mp4/* |

Here is an example for the movie Deadpool (2016) with some URLs (this would go on one line):
{ "id": "tt1431045", "sources": [ "http://s5.movies4star.xyz/load/Deadpool.2016.720p.BluRay.H264.AAC-RARBG/Deadpool.2016.720p.BluRay.H264.AAC-RARBG.mp4", "http://storm.pulsedmedia.com/media/bb4/new/Deadpool.2016.1080p.BluRay.MoviZLand.CoM.mp4", "http://s5.bitdownload.ir/Clips/Movie/foreign%28khareji%29/Dead.Pool/Deadpool.2016.1080P.BluRay.Censored.mp4" ] }
