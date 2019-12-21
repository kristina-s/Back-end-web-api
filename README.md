# Web API for my Front-end flowers e-shop

## About the project

This is a web API created in .NET Core that serves the front-end part of the project which is an online flowershop built with React framework (you can see that on https://github.com/kristina-s/React-project-eshop).
It gives the users the ability to login, register, see the items, add to cart and buy from the shop.

## Idea
While making the front-end part of the app, the data (the items in the e-shop) were json files on github and orders were only displayed in console, so the need to make a back-end that will receive the requests, processes them and communicates with a database was reason enough to start creating this project.

## Features
- Existing users can login and are authenticated by JWT tokens
- New users can register and records are saved on database for each new user
- The items are retreived from database and displayed on front-end
- Orders are saved to database for the user that is logged in

## Built with
 - Web API build with .NET Core
 - SQL database
 - Front-end built with React

 ## License
 Licensed under the MIT license.
