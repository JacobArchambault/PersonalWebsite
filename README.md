# PersonalWebsite
A .Net 8 website running in a Docker container making use of google analytics, custom routing, bundling and minification, ASP.NET MVC shared views, flexbox layouts, media queries, and bootstrap and jQuery CDN's, with links to my programming projects, published papers, resume and CV.

To run this program, ensure you have docker or another application for running containers (e.g., podman) installed on your computer. Then follow these steps: 
1. Open up a terminal and navigate to the root directory of this project.
2. To build a container image locally, type the command `docker build -t ja-personal-website .`, then press enter.
3. To run the container image you've just built, type `docker run  -p 9999:80 -e ASPNETCORE_URLS=http://*:80 ja-personal-website`*, then press enter.
4. Open a web browser and navigate to `localhost:9999/` to view the running application.

*For information on the use of the ASPNETCORE_URLS parameter, see https://learn.microsoft.com/en-us/dotnet/core/compatibility/containers/8.0/aspnet-port#recommended-action
