# Purpose
The purpose of this application is to assist me with the inventorying and cataloging of all of the IT Equipment and Assets of Adams Arms. The only features required for that purpose are:

 - The ability to log the Type of Equipment, Manufactuer,  Serial Number, Model Number, Description.
 - Generate a tracking number for internal Identification
 - print a label to be attached to the equipment for easy identification
 - export the Data from the DB into a CSV File.

The Files and Images for Generated from this application will be used to reach out to venders and equipment purchasers to get bids on dispositioning.

# Future
The purpose of the application was a one-off tool, without any immediate plans for future development beyond that. The below tasks are post development tinkering thoughts for 'further study'. 


# Tasks
- [ ] Refactor 
	- [ ] Data model, Item model, item class
		- Item class should, *i think* , have all of the SQL calls attached it rather than another class.
		- Future classes dealing with the DB should be done the same way.
	- [ ] Camera Code
	- [ ] form1.cs - Clean up and seperate code.
- [ ] Add a new table for photo's, allowing for adding mulitple photos to the same Item.
- [ ] Add persistance to the printer selection
- [ ] Add the ability to update a record
- [ ] Add the Ability to Start a new Database
- [ ] Create Setup Wizard


# Notes

## Printing

The printer formatting code is hard coded to work with a Zebra 450 thermal printer for printing 1 inch by 4 inch labels. This could change with furthering tinkering
### Possible Changes
- Adding presistant user defined settings for printer, size, margins, etc
- Adding a way to print reports
	- For Each Item
	- For All items



## Data
Right now the application serves a specific purpose, and as such the database wasn't designed to scale in any sense.  The database is a simple single table database with 7 feilds. Any expansion of this database would result in a lot of refacturing.


