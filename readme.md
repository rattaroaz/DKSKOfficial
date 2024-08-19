DKSK official app

Overview:  This app is going to be used internally amongst 5 users, a family business.  It is intended for a painting contractor to take orders and provide invoices.  General workflow: a client calls and requests a job (start job).  After the job is taken and scheduled, subcontractors are sent to perform the task.  Once the task is done, and invoice is created and tracked.

The app should be available through any browser, desktop and mobile.  2 types of users:  admin and guest.  Guests still need secure password, but they have only ability to view, to avoid any mistaken entries.  

The app requires 24/7 uptime, and is internal use only, but planned downtime is not a problem.

Data:  
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



Behavior of app.
Login: name, password
users:  Admin, guest
Admin has access to all
guest can view everything, but cannot change values

Start Job.  
Today's Date prepopulates with Today's date, but editable.  
Job Start Date and Anticipated Completion Date starts blank
Company - drop down list of companies in database. Can add one time CompanyName.
When the company is chosen, the Property/Address auto populates as a drop down, based upon the Company.
When the Property/Address is selected, it lists propery name and address.  can be editable.
rest of choices are default blank. PropertyName can be 1 time entry.
Size: bedroom, bathroom are integers
work order can be a combination of numbers and/or letters.

Job Description - drop down list.  can edit.  next input box is numerical for number of jobs needed.
Add another option creates new drop down list of same drop down list previously.
material costs is calculated with option of inputted
drop down Contractor draws from list of contractors
when hit Submit, the screen shows the options chosen.  The file becomes an object, then gets sent to "create invoice" section.

Aging reports.
list of all past unpaid files. to pay for file.  once done in Accounts Receivable, it goes here.
needs date option. 


Accounts receivable:
All files that have been submitted in "Create Invoice" go here.  all past unpaid files.
Checkbox goes after the "Amount paid"
All files are viewable only, except checkbox, where you can check it.  
When click Checkbox and Submit, opens up field next to the checkboxes to allow for:  
	checknumber (text field), amount (textfield), date paid (date)
Done button sends all checked files into saved storage.
if someone does partial payment, the file stays where it is with a recorded payment.  if amount paid is not full
	payment, then the checkbox option is still present.



Sales:
List of all files after "Create Invoice" - to include paid and unpaid files
able to sort files by company, property, supervisor, manager, work order
Search from Date and End date refer to the "Invoice Date"
After the Price column, there should be a viewable only checkbox for "Paid." 
Clicking on a row should open up details of the file.  Can then choose to go Back, Download to pdf, Download to Excel
Download to pdf and excel only for the viewed items, with option to download paid or unpaid.

Payroll:
	list of contractors, date of jobs, invoice for total amount, amount paid to contractor, and material costs
 

Add Contacts:
 
	Supervisor has Managers who work underneath them, so one Supervisor can have multiple Managers.
	All Companies and Properties have either a Supervisor, Manager, or both.
	Company option does not have Supervisor or Manager, since they might not be known at the time of 
		obtaining company.
	When hover over any name, tooltip should show selectable phone, email information.
	Adding Properties to Supervisor and Manager is optional at the time of creation.

Edit/View Contacts:  
	Add Company, Property, Supervisor, Manager, Contractors into database
	Edit and View Company, Property, Supervisor, Manager, Contractors
	Supervisor has Managers who work underneath them, so one Supervisor can have multiple Managers.
	All Companies and Properties have either a Supervisor, Manager, or both.
	Company option does not have Supervisor or Manager, since they might not be known at the time of 
		obtaining company.
	When hover over any name anywhere in the app, tooltip should show selectable phone, email information.
	Adding Properties to Supervisor and Manager is optional at the time of creation.

	Company radio button -> drop down of companies in database
		when drop down selected, list of properties all show up belonging to the company
		choice to add property.
		when clicking on a listed property to choose it, the property choices appear in
			editable section, but prepopulated with existing values.
		submit saves work.  cancel goes to the company drop down. revert reverses last
		change made
	Property radio button -> type in PropertyName or Address and autocompletes list of choices
		Add new property is the same as Add Contacts section for adding property
		When selected property, the property choices appear in
			editable section, but prepopulated with existing values.
		submit saves work.  cancel goes to the company drop down. revert reverses last
		change made


	Contractor radio button -> drop down list of contractors
		if contractor is selected, editable inputs
		Add Contractor will list empty editable inputs
		Submit, cancel, revert
		
	Supervisor radio button -> drop down list of contractor
		if supervisor is selected, editable inputs.
			list of managers and existing properties.  if click on manager or property, opens up the manager or
				the property component in same location
		Add Supervisor will list empty editable inputs
			can add managers and properties
		Submit, cancel, revert

	Manager radio button -> same behavior as supervisor

 
Contractor Jobs:
	list of jobs on the day selected.
	Can be past, present, and future.  Future will be pending jobs.


Create Invoice:
	All StartJob files go here.
	End date is optional.  If not chosen, then only the files with the exact start date is listed
	If End Date is entered, list of jobs by date that are available will be seen.
	checkbox exists on a column right of the price.  when checked, it opens up the entire details of the file,
	identical to the StartJob.  Then click Submit  then goes to accounts receivable, adds InvoiceDate (date of completion)
		
