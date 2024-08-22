## JobDescriptions
```
id: primary key, number
description: string
```
## Company
```
id: primary key, number
name: the name of company, string
owner:  the name of company owner, string
cell phone: phone number of company, string
email: email of company, string
address: address of company, string
city: city of company, string
zip: zip code of company, string
special note: string
```

## Supervisor
```
Supervisor:
id: primary key, number
company id: number
cell phone: string
email:
special note:
```

## Manager
```
id: primary key, number
supervisor id: number
name: string
cell  phone: string
email: string
special note
```

## Properties
```
id:
name:
address:
city:
zip
gate code:
lockbox:
special note
```

## Manaber2Properties
```
id:
manger id:
property id:
```

## supervisor2Properties
```
id
supervisor id
property id:
```

## Contractors
```
id
name
licensenumber
socialsecuritynumber
contractorID
payroll percent:
cell phone:
email:
address:
city:
zip:
special note:
```

## Invoice
```
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
```

## MyCompanyInfo
```
Company name
Address
City, State, Zip
Phone:
E-mail:
```