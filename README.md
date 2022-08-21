# National Parks Lookup API

#### By _Seung Lee_

#### _A simple API._

## Technologies Used

* _C#/.NET_
* _Entity Framework_


## Description

A simple API.

## Setup/Installation Requirements
_Requires console application such as Git Bash, Terminal, or PowerShell_

1. Open Git Bash or PowerShell if on Windows and Terminal if on Mac
2. Run the command

    ``git clone https://github.com/leark/ParksLookup.git``

3. Run the command

    ``cd ParksLookup``

* You should now have a folder `ParksLookup` with the following structure.
    <pre>ParksLookup
    ├── .gitignore 
    ├── ... 
    └── ParksLookup
        ├── Controllers
        ├── Models
        ├── ...
        ├── README.md
        └── Startup.cs</pre>

4. Add a file named appsettings.json in the following location, inside ParksLookup folder 

    <pre>ParksLookup
    ├── .gitignore 
    ├── ... 
    └── ParksLookup
        ├── Controllers
        ├── Models
        ├── ...
        ├── Startup.cs
        └── <strong>appsettings.json</strong></pre>
      
5. Copy and paste below JSON text in appsettings.json.

```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Warning",
      "System": "Information",
      "Microsoft": "Information"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=naparks;uid=root;pwd=[YOUR-PASSWORD-HERE];"
  },
  "JwtConfig": {
    "Secret" : "[YOUR-SECRET-HERE]"
  }
}
```

7. Replace [YOUR-PASSWORD-HERE] with your MySQL password.

8. Replace [YOUR-SECRET-HERE] with your random length 32 string.

9. Run the command

    ```dotnet ef database update```


<strong>To Run</strong>

Navigate to the following directory in the console
    <pre>ParksLookup
    └── <strong>ParksLookup</strong></pre>

Run the following command in the console

  ``dotnet build``

Then run the following command in the console

  ``dotnet run``

This program was built using _`Microsoft .NET SDK 5.0.401`_, and may not be compatible with other versions. Your milage may vary.

## API Documentation

### Animals
Access information on animals currently in the shelter.

#### HTTP Request Structure
```
GET /Parks
POST /Parks
GET /Parks/{id}
PUT /Parks/{id}
DELETE /Parks/{id}
```
* To utilize the POST request and create a new instance of an animal, the following information is required.
```
{
    "Name": "Yellowstone",
    "Website": "https://www.nps.gov/yell/index.htm",
    "StatePark": false,
    "StateId": 56,
    "Description": "The world's first national park that spans three states: Idaho, Montana, and Wyoming"
}
```
*StateId follows [FIPS Code](https://www.bls.gov/respondents/mwr/electronic-data-interchange/appendix-d-usps-state-abbreviations-and-fips-codes.htm)

#### Example Query
```
https://localhost:5000/Parks/1
```
#### Sample JSON Response
```
{
    "animalId": 1,
    "name": "Scooter",
    "species": "Dog"
}
```


## Known Bugs

* _No known issues_

## License

[GNU](/LICENSE)

Copyright (c) 2022 Seung Lee