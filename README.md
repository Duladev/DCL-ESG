# DCL-ESG
Manage ESG data in Diamond Cutters LTD

# SCREENS
    LOGIN
    EMPLOYEE DETAILS
    CSR ACTIVITIES
    WASTE MANAGEMENT
    PLASTIC INVENTORY
    HSE TRAINING & SAFETY

> # LOGIN PAGE
    username entry
    password entry
    Login Button
    Exit Button

> # Employee Details
    #Data Grid View
      Fields: Emp_No, Emp_Name,Gender, Category, Department, Date of Join, To or Present, Date of Birth, Age(y),Tenure (y), (if manager distance), Nationalities
    #Search Button
      Search by Emp_ID
    #Filters with Counter
      Gender, Category, Department, Nationalities
    #Export Excel

> #  CSR ACTIVITIES
    # Data Entries
      Date, Action, Description, Fequency, Location, Time of Engagement, Employees Envolved(Count), Hours Invested, People Impacted(count), Quantity, Cost(USD), Type
      Save Button, Refresh Button
    #Data Grid View with Date range Filter(for show entered data)
      Update Button Delete Button(when select a data from grid view fetch all data to textboxes for update and delete)

> #  Waste Management
    # Non-Recycled Waste
      Date Picker(for select date)
        Polythene
           Data Entrie - Qty(in Kg)
        Plastic
           Data Entrie - Qty(in Kg)
      Add New Item Button(for add new recycled waste item)
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
    # Chemical Waste
        Used Chemical Liquds
           Data Entrie - Qty(in Kg)
        Chemical Packing
           Data Entries - Qty(in Kg)
        Chemical Fabric
           Data Entrie - Qty(in Kg)
      Add New Item Button(for add new recycled waste item)
    Daily Total TextBox(Showing realtime calculated data when entering data to particular date)
    # Data Grid View with Filers
        Data Grid View for show entered data
        Filters - Recycled, Non-Recycled, Other Recycled, Chemical
        Update Button, Delete Button(when select a data from grid view fetch all data to textboxes for update and delete)
> # Inventory
        # Electricity
>         Electricity Purchase
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
              Additional Purchased
                Peak Time - Data Entry - Qty(KWh)
                Normal Time - Data Entry - Qty(KWh)
                Off-Peak Time - Data Entry - Qty(KWh)
                Payment For Main-Purchased
                Paid Amount For Peak Time - Data Entry - Amount(LKR)
                Paid Amount For Normal Time - Data Entry - Amount(LKR)
                Paid Amount For Off-Peak Time - Data Entry - Amount(LKR)
              Out-Source Purchased
                Type Of Renewable Source - DropDownMenu
                Total Purchased Capacity - Data Entry - Qty(KWh)
                Type Of Non-Renewable Source - DropDownMenu
                Total Purchased Capacity - Data Entry - Qty(KWh)
              Bill upload to server(should be save month bill path in database)
            Data View Panel
        Calendar(for select year and month)
        Data Grid View(for view previous data with uploaded bill location path in server)
>         Own Generated Electricity
                Type Of Own Generated Electricity Type(renewable) - DropDownMenu
                Monthly Generated Electricity capacity(renewable) - Data Entry Qty(KWh)
                Type Of Own Generated Electricity Type(non-renewable) - DropDownMenu
                Monthly Generated Electricity capacity(non-renewable) - Data Entry Qty(KWh)
                Total Own Generated Capacity(Consumed) - Data Entry Qty(KWh)
                Own Generated Sold Capacity - Formular((Monthly Generated Electricity capacity(renewable)+Monthly Generated Electricity capacity(non-renewable))-Total Own Generated Capacity(Consumed))

        
      
  
