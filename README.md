# PersonalWebsite
A containerized .Net 9 website running from a Kubernetes deployment making use of google analytics, custom routing, bundling and minification, ASP.NET MVC shared views, flexbox layouts, media queries, and bootstrap and jQuery CDN's, with links to my programming projects, published papers, resume and curriculum vitae.

To run this application, ensure you have docker or another application for running containers (e.g., podman) installed on your computer. Then follow these steps: 
## Build a local container image of the application
1. Open up a terminal and navigate to the root directory of this project.
2. To build a container image locally, type the command `sudo docker build -t ja-personal-website .`, then press enter.

## Run the application
3. To run the container image you've just built with Docker, type `sudo docker run --name ja-personal-website-container -p 8000:8080 ja-personal-website`, then press enter.
4. To run the application with podman, run ` sudo podman kube play personal-website-deployment.yaml`. To stop the application and remove pods, run `sudo podman kube down personal-website-deployment.yaml`.

## View the running application
5. Open a web browser and navigate to `localhost:8000/` to view the running application.
