# SillyStringFactory

#### By William Jameson

#### An organizational tool for Factory owners

## Technologies Used

* C#
* .Net
* Entity
* MySql

## Description

This webapp allows the user to add and organize different engineers and different machines, store the input in a database for future reference and alter or delete entries as needed, associating engineers with the machines they are able to service.

## Setup/Installation Requirements

* Navigate to the github repository by following the url https://github.com/wcjameson/SillyStringFactory.Solution
* You can clone the repository to your machine by following these steps
* In your terminal enter the following
* git clone https://github.com/wcjameson/SillyStringFactory.Solution
* Install MySql
* In the production directory, run the following command
* dotnet ef database update
* This will apply the latest migration, to setup the database
* Make sure to create a connection to the database that was created
* Do this by creating an appsettings.json file in the Factory project directory
* It should look like this
`{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=william_jameson;uid=root;pwd={password};"
  }
}`
* User id and password will be your own
* Open the project in your terminal, navigate to the Factory directory, and enter the following
* dotnet restore
* dotnet build
* dotnet run
* Open your browser and navigate to http://localhost:5000/


## Known Bugs

* Currently no know issues

## License
MIT License

Copyright (c) [2022] [William Jameson]

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.

## Contact Information

* Contact at <williamjameson90@gmail.com>