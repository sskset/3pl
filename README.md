# Welcome to 3P Learning Grouping Test Students Microservice

This is a REST service aiming to group students by vertically, horizontally and diagonally adjacent cells.

## Input: POST request

Time & Marks Matrix - a multi-dimention array of students with unique names in string format

`{ {'Jack','','','',''}, {'','', '','Thomas',''}, {'','','','',''}, {'','Chris','','',''}, {'','Harry','', 'Roger',''}, {'','','','',''} }`

## Output:

Students grouped by curly brackets

`{{Jack},{Thomas},{Chris,Harry},{Roger}}`

## Prerequisites:

1. .NET Core 2.2
2. Visual Studio 2017

## Usage

1.  Run \*.sln with Visual Studio 2017
2.  Start GroupTestStudentAPI project
3.  Use Postman to create a POST request with following body (raw string) to http://localhost:5010/api/GroupTestStudent
    > {
        {'','',’Simon’,'',''},
        {'',’Sergey', '','Thomas',''},
        {'','','','',''},
        {'','Chris','','',''},
        {'','Harry','', 'Roger',''},
        {'','','','',''}
    }
4.  Check response
