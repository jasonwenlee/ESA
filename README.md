**This is a new repo for ESA**
# Encyclopedia for oculoplastic surgery and diagnosis
This is an open source encyclopedia-esque mobile application detailing different oculoplastic surgical procedures and diagnosis. The aim of this application is to also provide a universal template for future medical procedures outside the field of oculoplastic. The application is built using a Model-View-ViewModel (MVVM) structure with an ASP.NET backend framework.

### Overview of app structure
The design of the application consists of a front page listview, video player, and five different content pages for each oculoplastic procedure. Each content page and procedure will have its own respective Model, ViewModel, and View. The video player appended at the top of each content page will play a video of the procedure and can be minimised to allow more view of the content. 

#### Images
Front page list view  | Content page view
--------------------- | ------------------
<img src="https://github.com/jasonwenlee/ESA_P2/blob/readme/images/gif1.gif" width="314" height="628"> | <img src="https://github.com/jasonwenlee/ESA_P2/blob/readme/images/gif3.gif" width="314" height="628">

## Getting Started
### Prerequisites
* Knowledge of MVVM architecture
* Experience with Microsoft Visual Studio IDE. Team is using Microsoft Visual Studio Enterprise 2019.
* Microsoft SQL Server Management for database and also MYSQL for drawing ERD diagram
* Understand ASP.NET framework for backend tasks such as sending queries through API to database
* Microsoft Azure for cloud hosting
* Setting up work environment to host api and database on a local machine for individual user through IIS. This allows test queries to be executed locally without the need to host the API online. 

## License
This project is licensed under the MIT License - see the [LICENSE.md](LICENSE) file for details
