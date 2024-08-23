# DKSK official app


### Overview:

This app is going to be used internally amongst 5 users, a family business.  It is intended for a painting contractor to take orders and provide invoices.  General workflow: a client calls and requests a job (start job).  After the job is taken and scheduled, subcontractors are sent to perform the task.  Once the task is done, and invoice is created and tracked.

 The app should be available through any browser, desktop and mobile.  2 types of users:  admin and guest.  Guests still need secure password, but they have only ability to view, to avoid any mistaken entries.  

 The app requires 24/7 uptime, and is internal use only, but planned downtime is not a problem.

### Data:  

```
ThisCompany (the one that owns the app):
	ThisCompanyName
	ThisCompanyAddress
	ThisCompanyCity
	ThisCompanyZip
	ThisCompanyPhone
	ThisCompanyEmail

Company:	
	CompanyName
	Managers - multiple
	CompanyOwner
	CompanyAddress
	CompanyCity
	CompanyZip
	
Job Descriptions:
	Interior wall, closet inside, ceiling
	Walls, closet inside
	Base boards
	Kitchen cabinet - inside and outside
	All enamel surfaces including doors, door frames, kitchen, bathroom
	2 tone colors, navaho white, swiss coffee
	2 tone colors:  BM1520 (Hushed Hue), swiss coffee
	Balcony floor
	Cover flooring and plastic
	Ceiling

Manager:
	ManagerName
	CompanyName
	ManagerCellPhone 
	ManagerEmail
	PropertyName - multiple
	ManagerSpecialNote


Properties:
	PropertyName
	CompanyName
	PropertyAddress
	PropertyCity
	PropertyZip
	PropertyGateCode
	PropertyLockBox
	ManagerName
	PropertySpecialNote

Contractors:
	ContractorName
	ContractorLicenseNumber
	ContractorSocialSecurityNumber
	ContractorID
	ContractorPayrollPercent
	ContractorCellPhone
	ContractorEmail
	ContractorAddress
	ContractorCity
	ContractorZip
	ContractorSpecialNote

Invoice:
	TodaysDate
	StartDate
	AnticipatedEndDate
	CompanyName
	PropertyAddress
	Unit#
	GateCode
	Lockbox
	SizeBedroomBathroom
	WorkOrder
	JobDescriptionChoice
	ContractorName
	AmountCost
	Paid
	AmountPaid
	CheckNumber



Home:
Company Logo
Address
City, State, Zip
Phone:
E-mail:
all this is editable in the existing location.  no separate page needed.

Left upper corner
users:  Admin, guest
Admin has access to all
guest can view everything, but cannot change values
Loginpage: name, password
```

### Behavior of app.

```
Start Job.  
Today's Date prepopulates with Today's date, but editable.  
Job Start Date and Anticipated Completion Date starts blank.
Company - drop down list of companies in database. Can add one time CompanyName by typing in new value.
When the Company is chosen, the Property/Address choices that belong to the Company auto populate as a drop down, based upon the Company.
When the Property/Address is selected, it lists propery name and address.  Property address is uneditable.  Options: Unit number, Gate Code, Lock Box, Size, Work order - start blank.
PropertyName can be 1 time entry by typing it in.
Size: bedroom, bathroom are integers
Gate Code, Lock Box, Work Order can be a combination of numbers and/or letters.

Job Description - drop down list.  can edit to add one time option only.   
Add another option creates new drop down list of same drop down list previously.
Material Costs is determined from the New Jobs component and value is autopopulated.
Can edit value one time only.
Remove button on the right side of every row, to delete existing inputs.
Drop down Contractor draws from list of contractors
when hit Submit, the screen shows the options chosen.  The file becomes an object, then gets sent to "create invoice" section.

Aging reports.
List of all past unpaid files. to pay for file.  once done in Accounts Receivable, it goes here.
needs date option. 


Accounts receivable:
All files that have been submitted in "Create Invoice" go here.  These files are unpaid, by definition.  
Checkbox goes after the "Amount paid" on the same row - please change to "Amount to be Paid"
All files are viewable only, except checkbox, where you can check it.  
Submit button should be right of the Done button.
When click Checkbox and Submit, opens up field next to the checkboxes to allow for:  
	checknumber (text field), amount (textfield), date paid (date)
Multiple boxes can be checked before clicking Submit.
Done button sends all checked files into saved storage and removes from this page.  They can now be seen on Aging Reports
if someone does partial payment, the file stays where it is with a recorded payment.  if amount paid is not full
	payment, then the checkbox option is still present.

***



Sales:
List of all files from "Accounts Receivable" *** - to include paid and unpaid files
able to sort files by company, property, manager, work order
Search from Date and End date refer to the "Invoice Date"
After the Price column, there should be a viewable only checkbox for "Paid." 
Clicking on a row should open up details of the file.  Can then choose to go Back, Download to pdf, Download to Excel
Download to pdf and excel only for the viewed items, with option to download paid or unpaid.

Payroll:
	List of contractors, start date of jobs, invoice for total amount, amount paid to contractor, and material costs
	Needs to add at least Start Date to look up jobs.  If End Date is chosen, list all jobs with Start Date between the two dates.

Contacts:
	All Companies AND Properties have a Manager.
	When hover over any name of a person, tooltip should show selectable phone, email information.
	Adding Properties to Manager is optional at the time of creation.

	Company radio button -> drop down of companies in database
		When drop down selected, Company information is listed in editable form.
			List of properties all show up belonging to the company
				Choice to add property.
		Drop down for Company is not editable.
		Add Company button opens up Company information which is blank.
		When clicking on a listed property to choose it, the property choices appear in
			editable section, but prepopulated with existing values.  See Property section
		Add Property button allows addition of the property to the Company.
		Submit saves work.  Cancel goes to the company drop down. Revert reverses last 5 changes made
		If user clicks away and then returns, page should be unchanged from previous view

	Property radio button -> type in PropertyName or Address and autocompletes list of choices
		Upon choosing PropertyName, property information is listed and editable.
		Add new property has the same information options, but blank.
		Submit saves work.  Cancel goes to the company drop down. Revert reverses last 5 changes made
		If user clicks away and then returns, page should be unchanged from previous view


	Contractor radio button -> drop down list of contractors
		If contractor is selected, editable inputs
		Add Contractor will list empty editable inputs
		Submit saves work.  Cancel goes to the company drop down. Revert reverses last 5 changes made
		If user clicks away and then returns, page should be unchanged from previous view
		
	Manager radio button -> drop down list of Manager
		If Manager is selected, editable inputs appear, prepopulated with that Manager's information.
		List of properties.  If click on a shown Property, opens up the Property component in same location to edit the information.
		Add Manager button will list empty editable inputs, and blank the drop down value.
		Add Property will show text box to type in Property from database.  Autocomplete and can choose a Property.
		Add Property can be chosen again to add another property the same as above.
		Special Note is any misc information needed about the Manager.
		Submit saves work.  Cancel goes to the company drop down. Revert reverses last 5 changes made

 
Contractor Jobs:
	List of jobs on the day selected.
	Can be past, present, and future.  Future will be pending jobs.


Create Invoice:
	All StartJob files go here.
	End date is optional.  If not chosen, then only the files with the exact start date is listed
	If End Date is entered, list of jobs by date that are available will be seen.
	Click on an item row, it opens up the entire details of the file, ientical to the StartJob.
	Then click Submit then goes to accounts receivable, adds InvoiceDate (date of completion)
	
NewJobs:
	This section is to add types of jobs and define the cost of the materials.
	Prepopulated cost of the materials can be edited.
	Once edited, any future job will be using that value, but it will not retroactively change any values.
	Can add new jobs as needed.  Can Delete Jobs with a Delete button at the right of the rows.  If clicked, "Are you sure?" warning is given.
		
```
