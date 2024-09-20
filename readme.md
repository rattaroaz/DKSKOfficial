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
	Supervisors - multiple
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
	SupervisorNames - multiple
	PropertyName - multiple
	ManagerSpecialNote

Supervisor
	SupervisorName
	CompanyName
	SupervisorCellPhone
	SupervisorEmail
	ManagerName
	PropertyName - multiple
	SupervisorSpecialNote


Properties:
	PropertyName
	CompanyName
	PropertyAddress
	PropertyCity
	PropertyZip
	PropertyGateCode
	PropertyLockBox
	SupervisorName
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
	WorkDate
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
	AmountPaid1
	CheckNumber1
	AmountPaid2
	CheckNumber2



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
When the Company is chosen, the Property/Address choices that belong to the Company auto populate as a drop down, based upon the Company.  Can type in to autopopulate.
When the Property/Address is selected, it lists propery name and address.  Property address is uneditable.  Options: Unit number, Gate Code, Lock Box, Size, Work order - start blank.
PropertyName can be 1 time entry by typing it in.
Size: bedroom, bathroom are integers
Gate Code, Lock Box, Work Order can be a combination of numbers and/or letters.

Job Description - drop down list.  Can edit to add one time job option only.   
Add another option creates new drop down list of same drop down list previously.
Can enter a one time text value as needed for the Job Type.
Remove button on the right side of every row, to delete existing inputs.
Drop down Contractor draws from list of contractors
when hit Submit, the screen shows the options chosen.  The file becomes an Invoice, then gets sent to "Create Invoice" section.

Create Invoice:
	All StartJob Invoices go here.
	End date is optional.  If not chosen, then only the Invoices with the exact start date is listed.
	If End Date is entered, list of jobs that fall within date range will be seen.
	Click on an item row, it opens up the entire details of the Invoice, ientical to the StartJob, with editable view.
	Add fields for Contractor, Job Description, Job Description price, Material cost, Material cost price, 4 blank fields to manually type (item Description) followed by price. 
	Delete option on far right of the rows.  Ask "Are you sure?" if clicked.
	Autogenerate an Invoice number
	Then click Submit then the Invoice goes to Accounts Receivable and Aging Reports, adds InvoiceDate (date of completion)

Accounts receivable:
All Invoices that have been submitted in "Create Invoice" go here, to be paid.  
Search by Company drop box.
Checkbox goes to the right of the "Amount paid" on the same row - please change to "Invoice Total"
All Invoices are viewable only, except checkbox, where you can check it.  
Submit button should be right of the Done button.
When click Checkbox and Submit, opens up field next to the checkboxes to allow for:  
	checknumber (text field), amount (textfield), date paid (date)
Multiple boxes can be checked before clicking Submit.
Done button sends all checked Invoices into saved storage and removes from this page.  They can now be seen on Sales.
If someone does partial payment, the Invoice stays where it is with a recorded payment.  If amount paid is not full
	payment, then a new checkbox option shows up right below the first payment.

Aging reports.
Search by Start Date and End Date.
Search by Company and Supervisor radio buttons.
List of all past unpaid Invoices. After Invoice is created (but not paid), they are listed here.  
Days Overdue is calculated by Today's Date - Invoice Date.
If only Start Date is entered, then list all invoices with that date.
Once radio button clicked, list of all Invoices by Company or Supervisor is shown.


Sales:
List of all Invoices from "Accounts Receivable" - to include paid and unpaid Invoices
Able to sort Invoices by company, property, supervisor, manager, work order, invoice number
Search from Start Date and End date refer to the "Invoice Date"
After the Price column, there should be a viewable only checkbox for "Paid." 
Clicking on a row should open up all details of the Invoices - Invoice.  Can then choose to go Back, Download to pdf, Download to Excel
Download to pdf and excel only for all items, viewed items, paid, unpaid.

Payroll:
	List of contractors, Start Date of jobs (NOT invoice date), invoice for total amount, amount paid to contractor, and material costs
	Needs to add at least Start Date to look up jobs.  If End Date is chosen, list all jobs with Start Date between the two dates.
	Add property address, unit number.  Remove Paid to contractor.

Contacts:
 	Supervisor has Managers who work underneath them, so one Supervisor can have multiple Managers.
	All Companies AND Properties have either a Supervisor, Manager, or both.
	When hover over any name of a person, tooltip should show selectable phone, email information.
	Adding Properties to Supervisor and Manager is optional at the time of creation.

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


	Contractor radio button -> drop down list of contractors
		If contractor is selected, editable inputs
		Add Contractor will list empty editable inputs
		Submit saves work.  Cancel goes to the company drop down. Revert reverses last 5 changes made
		If user clicks away and then returns, page should be unchanged from previous view
		License expiration date, Workman's Compensation insurance policy number and expiration date, Bond number and expiration date.
		
	Supervisor radio button -> drop down list of Supervisor
		If supervisor is selected, editable inputs appear.
			List of managers and existing properties.  If click on manager or property, opens up the manager or
				the property component in same location to edit the manager or property
				Can also delete managers and properties
		Add Supervisor will list empty editable inputs and blank the drop down value.
			Can add managers and properties that exist in database.
		Add Manager and Add Property wil show text box to type in Manager or Property from database.  Autocomplete and can choose multiple Managers or Properties.
		Submit saves work.  Cancel goes to the company drop down. Revert reverses last 5 changes made
		If user clicks away and then returns, page should be unchanged from previous view
 
Contractor Jobs:
	List of jobs on the day selected.
	Can be past, present, and future.  Future will be pending jobs.


NewJobs:
	This section is to add types of jobs and define the cost of the materials.
	Prepopulated cost of the materials can be edited.
	inputs include: text (desription of job), 2 integers (size: bedroom, bathroom), price (dollar), and delete button.
	Values of Size:  (0,1), (1,1), (2,1), (2,2), (3,2), (3,3)
	Once edited, any future job will be using that value, but it will not retroactively change any values.
	Can add new jobs as needed.  Can Delete Jobs with a Delete button at the right of the rows.  If clicked, "Are you sure?" warning is given.
		
```
