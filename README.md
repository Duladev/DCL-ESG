# DCL-ESG
Manage ESG data in Diamond Cutters LTD

# SCREENS
    LOGIN
    EMPLOYEE DETAILS
    CSR ACTIVITIES
    WASTE MANAGEMENT
        WASTE COLLECTORS MANAGEMENT
    INVENTORY
        Electricity
        Water
        Gas
        Plastic
        Paper
    HSE TRAINING & SAFETY
    SOCIAL
    Minorities

> # LOGIN PAGE
    username entry
    password entry
    Login Button
    Exit Button
database connect from login page
> # Employee Details
    #Data Grid View
      Fields: Emp_No, Emp_Name,Gender, Category, Department, Date of Join, To or Present, Date of Birth, Age(y),Tenure (y), (if manager distance), Nationalities
    #Search Button
      Search by Emp_ID
    #Filters with Counter
      Gender, Category, Department, Nationalities
    #Export Excel Button
Emp_Details View
SELECT        TOP (100) PERCENT FullEmpNo, EMP_NO, EPF_NO, SURNAME, INITIALS, NAME, NIC, DATE_JOINED, DEPT_CODE, DepartmentName, GRP_CODE, GRP_DESC, SECT_CODE, SECTION_DESC, DESIGNATION, SEX, GRADE, 
                         PROCESS_TYPE, WanCode, Pay, PreFix, CATEGORY, ProductName, ADD1, ADD2, ADD3, TargetDate, DEACTIVATE, RELIGION, Nationality
FROM            PAYROLL.dbo.vw_pay_emp_master
WHERE        (Pay = 1)

> #  CSR ACTIVITIES
    # Data Entries
      Activity Date, Action, Description, Fequency, Location, Time of Engagement, Employees Envolved(Count), Hours Invested, People Impacted(count), Quantity, Cost(USD), Type, Photos Uploaded(can be multiple photos upload to specific folder in server.should be save in database that path)
      Save Button, Refresh Button
    #Data Grid View with Date range Filter(for show entered data)
        excel export button(all data export as an excel sheet)
      Update Button Delete Button(when select a data from grid view fetch all data to textboxes for update and delete)
> #  Waste Management
>   WATSE COLLECTORS MANAGEMENT
      collector name
      address
      telephone number
      license number
      license documents upload
      data grid view for view registered collectors view and update.
>   Waste management
    # Non-Recycled Waste
      Date Picker(for select date)
        Polythene
           Data Entrie - Qty(in Kg)
        Plastic
           Data Entrie - Qty(in Kg)
      Add New Item Button(for add new recycled waste item)
      Select a collector from dropdown menu
      documents upload button for if have any documents
    # Recycled Waste
        Paper
           Data Entrie - Qty(in Kg)
        Cardboard
           Data Entrie - Qty(in Kg)
        Recycled Plastic
           Data Entrie - Qty(in Kg)
        Other Plastic Recycled
           Data Entrie - Qty(in Kg)
      Add New Item Button(for add new recycled waste item)
      Select a collector from dropdown menu
      documents upload button for if have any documents
    # Other Recycled Waste
        Organic Waste(Food)
           Data Entrie - Qty(in Kg)
           Two Check Buttons(Compost or Animal Feed)
        Copper
           Data Entrie - Qty(in Kg)
        Aluminium
           Data Entrie - Qty(in Kg)
        Glass
           Data Entrie - Qty(in Kg)
        Electronic Waste
           Data Entrie - Qty(in Kg)
      Add New Item Button(for add new recycled waste item)
      Select a collector from dropdown menu
      documents upload button for if have any documents
    # Chemical Waste
        Used Chemical Liquds
           Data Entrie - Qty(in Kg)
        Chemical Packing
           Data Entries - Qty(in Kg)
        Chemical Fabric
           Data Entrie - Qty(in Kg)
      Add New Item Button(for add new recycled waste item)
      Select a collector from dropdown menu
      documents upload button for if have any documents
>Daily Total TextBox(Showing realtime calculated data when entering data to particular date)
    # Data Grid View with Filers
        Data Grid View for show entered data
        Filters - Recycled, Non-Recycled, Other Recycled, Chemical
        Update Button, Delete Button(when select a data from grid view fetch all data to textboxes for update and delete)
        Excel Export Button
> # Inventory
        # Electricity
>  Electricity Purchase
        Data Entry Panel
           DropDown Menu
            Main Purchase and Additional Purchase
              Main Purchased
                Peak Time - Data Entry - Qty(KWh)
                Normal Time - Data Entry - Qty(KWh)
                Off-Peak Time - Data Entry - Qty(KWh)
                Payment For Main-Purchased
                Paid Amount For Peak Time - Data Entry - Amount(LKR)
                Paid Amount For Normal Time - Data Entry - Amount(LKR)
                Paid Amount For Off-Peak Time - Data Entry - Amount(LKR)
                Bill Upload (can be multiple bills upload to specific folder in server.should be save in database that path)
              Additional Purchased
                Peak Time - Data Entry - Qty(KWh)
                Normal Time - Data Entry - Qty(KWh)
                Off-Peak Time - Data Entry - Qty(KWh)
                Payment For Main-Purchased
                Paid Amount For Peak Time - Data Entry - Amount(LKR)
                Paid Amount For Normal Time - Data Entry - Amount(LKR)
                Paid Amount For Off-Peak Time - Data Entry - Amount(LKR)
                Bill Upload (can be multiple bills upload to specific folder in server.should be save in database that path)
              Out-Source Purchased
                Type Of Renewable Source - DropDownMenu
                Total Purchased Capacity - Data Entry - Qty(KWh)
                Type Of Non-Renewable Source - DropDownMenu
                Total Purchased Capacity - Data Entry - Qty(KWh)
                Bill Upload (can be multiple bills upload to specific folder in server.should be save in database that path)
         Own Generated Electricity
                Type Of Own Generated Electricity Type(renewable) - DropDownMenu(solar/wind power/hydropower/geothermal/biomass energy/wave energy/green hydregon/tidal energy)
                Monthly Generated Electricity capacity(renewable) - Data Entry Qty(KWh)
                Type Of Own Generated Electricity Type(non-renewable) - DropDownMenu(coal, natural gas, oil, nuclear energy, diesal, peat,shale gas and oil, tar sand(oil sand)
                Monthly Generated Electricity capacity(non-renewable) - Data Entry Qty(KWh)
                Total Own Generated Capacity(Consumed) - Data Entry Qty(KWh)
                Own Generated Sold Capacity - Formular((Monthly Generated Electricity capacity(renewable)+Monthly Generated Electricity capacity(non-renewable))-Total Own Generated Capacity(Consumed))
                Bill Upload (can be multiple bills upload to specific folder in server.should be save in database that path)
                Comments
        Data View Panel
        Calendar(for select year and month)
        Data Grid View(for view previous data with uploaded bill location path in server)
        Save, Delete, Update buttons(when select a data from grid view fetch all data to textboxes for update and delete)
        Excel Export Button
    # Gas
      Calender(for month and year select)
      Type of Gas - DropDownMenu
      Main Purchased Gas - Data Entry Qty(KWh)
      Amount
      Add Gas Type Button(for add gas type)
      Data Grid View with Filers
      Data Grid View for show entered data
      Filters - Gas Type
      Save Button, Update Button, Delete Button(when select a data from grid view fetch all data to textboxes for update and delete)
      Bill Upload (can be multiple bills upload to specific folder in server.should be save in database that path)
      Excel Export
    # Water
    Water Purchased(frmMain)
      Calender(for month and year select)
      Water Monthly Purchased - Data Entry Qty(cubic meter)
      Amount paid - Data Entry(LKR)
      Additional Water Monthly Purchased - Data Entry Qty(cubic meter)
      Additional Amount Paid - Data Entry(LKR)
      Bill Upload (can be multiple bills upload to specific folder in server.should be save in database that path)
    >RainWater Management(Removed)
      RainWater Collected - Data Entry Qty(cubic meter)
      RainWater Consumed - Data Entry Qty(cubic meter)
      RainWater Recycled - Data Entry Qty(cubic meter)
      Comments
      Data Grid View with Filers
      Data Grid View for show entered data
      Filter - Month
      Save Button, Update Button, Delete Button(when select a data from grid view fetch all data to textboxes for update and delete)
      Bill Upload Button to server(should be save month bill path in database)
      Excel Export Button
    # Plastic
      Data Entry Panel
      Calendar(for select the year and month)
      Product Category, Product Type, Type OF Unit, Purchased Unit Count, weight per unit, purchased scale(formular=weight per unit*purchased unit count), Price Per Unit, Total Purchase Cost(formular=price per unit*purchased unit count)
      Comments
      Data Grid View with Filers
      Data Grid View for show entered data
      Filter - Product Category, Product Type
      Save Button, Update Button, Delete Button(when select a data from grid view fetch all data to textboxes for update and delete)
      Bill Upload (can be multiple bills upload to specific folder in server.should be save in database that path)
      Excel Export Button
    # Paper
      Data Entry Panel
      Calendar(for select the year and month)
      Product Category, Product Type, Type OF Unit, Purchased Unit Count, weight per unit, purchased scale(formular=weight per unit*purchased unit count), Price Per Unit, Total Purchase Cost(formular=price per unit*purchased unit count)
      Comments
      Data Grid View with Filers
      Data Grid View for show entered data
      Filter - Product Category, Product Type
      Save Button, Update Button, Delete Button(when select a data from grid view fetch all data to textboxes for update and delete)
      Bill Upload (can be multiple bills upload to specific folder in server.should be save in database that path)
      Excel Export Button
>     #HSE Training, Safety Incident & Grievances
            Data Entry Panel For HSE Training
            Number of people that attended health & safety training, 
            Number of people that attended first-aid class/workshop, 
            Number of people that attended fire-fighting class,  
            Number of people that attended another awareness workshop (please specifiy which one)

            Data Entry Panel For Safety Incident
            Number of property damage incidents, 
            Number of environmental incidents, 
            Number of near misses, Total number of accidents, 
            Number of accidents which resulted in injuries, 
            Number of accidents which resulted in illness, 
            Number of accidents which resulted in death
            Total Incident Counter
            
            Data Entry Panel For Grievances
            Total number of employees grievances
            Number of unresolved employees grievances
>     Social
        Data Entry
        Calendar(for select month and year)
        Gender Counts(Male/Female)
        Age Categories(counts) - DropDownMenu(17 years old or less,Between 18 and 30 years old,Between 31 and 50 years old,50 years old or above)
    Required Skills(counts)
        Among the total number of employees,total number of people that learnt the job's skills at NIRU this year or in the past	
        Number of people hired already qualified, with that specific skills	
        Number of people that didn't work in our industry before coming to NIRU
    Promotions(count)
        Among the total number of employees, the number of employees who received a promotion during the reporting period
    Internal Mobility(count)
        Among the total number of employees, the number (or percentage) of employees who experienced an internal role change during the reporting period
    Family(count)
        "Number of people of the same family working in the company If one mum and her daughter, please count it as 2"
    Management(counts)
        Number of women in first-line management (team leader, supervisor, manager)	
        Number of men in first-line management (team leader, supervisor, manager)	
        Number of women at at middle-level  management (senior manager)	
        Number of men at middle-level  management (senior manager)	
        Number of women at at upper-level  management (head of department, director)	
        Number of men at at upper-level  management (head of department, director)
        Number of women  among the 12 people representing the group leadership team 
        Number of men among the 12 people representing the group leadership team 
>      Minorities
        Disabilities - Counts
             Physical Disabilities 
             Sensory Disabilities
             Mental Health Conditions
             Intellectual and Developmental Disabilities
             Chronic Health Conditions
        Behaviour - Counts
             Lesbian
             Gay
             Bisexual
             Asexual
             Pansexual
        Identifications - Counts
             Transgender
             Queer
             Questioning
             Non-binary
             Agender
        Nations - Counts
            African
            Asian
            Hispanic/Latino
            Indigenous
            Middle Eastern/North African
            Pacific Islander
            European
            Other Ethnicities => Please specify and count
        Religions - Counts
            Christianity
            Islam
            Hinduism
            Buddhism
            Judaism
            Sikhism
            Other Religions => Please specify (R.Catheloic) and count
            No Religion
        Languages - Counts
            Language A => Sinhala
            Language B => Hebrew
            Language C => French
            Language D => Hindi

Repots export as individualy(for each tabs).
Added final summerized report with all tabs.(filter by year).
Save button add as seperately for each tabs.
reduce row size in data grid view(too much size).
Age added categories should be show when added the count.
Add date picker for all tabs.



Use 65 Commit for withoutr QC updates
should be guide all components how to apply and their names and other attributes.
when upload the particular documents when data entry should be save file path in database.
should be can multiple documents upload for same record same time.
Data Grid views shold be clear when loading the forms.
when sql table create name start as tbl_ESG_
if create sql views names start as vw_
