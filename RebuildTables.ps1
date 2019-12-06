Param(
   [string] $Server = "(localdb)\TravelAgency",
   [string] $Database = "TravelAgency"
)

# This script requires the SQL Server module for PowerShell.
# The below commands may be required.

# To check whether the module is installed.
# Get-Module -ListAvailable -Name Sqlps;

# Install the SQL Server Module
# Install-module -Name SqlServer -Scope CurrentUser

# Import the SQL Server Module.    
# Import-Module Sqlps -DisableNameChecking;

Write-Host ""
Write-Host "Rebuilding database Tables $Database on $Server..."

Write-Host "Creating tables..."
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "DataModeling\Sql\Tables\BuildTables.sql"

Write-Host "Inserting data..."
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "DataModeling\Sql\Data\AgentsData.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "DataModeling\Sql\Data\CitiesData.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "DataModeling\Sql\Data\CustomerData.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "DataModeling\Sql\Data\TripsData.sql"

Write-Host "Creating Agency Create procedures..."
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "DataModeling\Sql\Procedures\AgencyProcedures\Agency.CreateAgent.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "DataModeling\Sql\Procedures\AgencyProcedures\Agency.CreateAttractionTicket.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "DataModeling\Sql\Procedures\AgencyProcedures\Agency.CreateBoardingPass.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "DataModeling\Sql\Procedures\AgencyProcedures\Agency.CreateCarRentalReservation.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "DataModeling\Sql\Procedures\AgencyProcedures\Agency.CreateCustomer.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "DataModeling\Sql\Procedures\AgencyProcedures\Agency.CreateHotelReservation.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "DataModeling\Sql\Procedures\AgencyProcedures\Agency.CreateRestaurantReservation.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "DataModeling\Sql\Procedures\AgencyProcedures\Agency.CreateTrip.sql"

Write-Host "Creating Agency Get procedures..."
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "DataModeling\Sql\Procedures\AgencyProcedures\Agency.GetAgent.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "DataModeling\Sql\Procedures\AgencyProcedures\Agency.GetAgents.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "DataModeling\Sql\Procedures\AgencyProcedures\Agency.GetCustomer.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "DataModeling\Sql\Procedures\AgencyProcedures\Agency.GetCustomers.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "DataModeling\Sql\Procedures\AgencyProcedures\Agency.GetTrip.sql"

Write-Host "Creating Agency Retrieve procedures..."
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "DataModeling\Sql\Procedures\AgencyProcedures\Agency.RetrieveAgentTrips.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "DataModeling\Sql\Procedures\AgencyProcedures\Agency.RetrieveCustomerContactInfo.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "DataModeling\Sql\Procedures\AgencyProcedures\Agency.RetrieveCustomerTrips.sql"

Write-Host "Creating Agency Save procedures..."
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "DataModeling\Sql\Procedures\AgencyProcedures\Agency.SaveCustomerContactInfo.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "DataModeling\Sql\Procedures\AgencyProcedures\Agency.SaveTrip.sql"

Write-Host "Creating Airlines procedures..."
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "DataModeling\Sql\Procedures\AirlinesProcedures\Airlines.CreateBoardingPass.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "DataModeling\Sql\Procedures\AirlinesProcedures\Airlines.CreateFlight.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "DataModeling\Sql\Procedures\AirlinesProcedures\Airlines.RetrieveFlightInfo.sql"

Write-Host "Creating Attractions procedures..."
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "DataModeling\Sql\Procedures\AttractionsProcedures\Attractions.CreateAttraction.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "DataModeling\Sql\Procedures\AttractionsProcedures\Attractions.GetAttraction.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "DataModeling\Sql\Procedures\AttractionsProcedures\Attractions.GetAttractionTicket.sql"

Write-Host "Creating Cars procedures..."
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "DataModeling\Sql\Procedures\CarsProcedures\Cars.CreateCarRental.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "DataModeling\Sql\Procedures\CarsProcedures\Cars.GetAgencyName.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "DataModeling\Sql\Procedures\CarsProcedures\Cars.GetCarReservationInfo.sql"

Write-Host "Creating Hotels procedures..."
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "DataModeling\Sql\Procedures\HotelsProcedures\Hotels.CreateHotel.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "DataModeling\Sql\Procedures\HotelsProcedures\Hotels.CreateHotelReservation.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "DataModeling\Sql\Procedures\HotelsProcedures\Hotels.GetHotel.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "DataModeling\Sql\Procedures\HotelsProcedures\Hotels.GetHotelReservation.sql"

Write-Host "Creating Location procedures..."
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "DataModeling\Sql\Procedures\LocationProcedures\Location.CreateCity.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "DataModeling\Sql\Procedures\LocationProcedures\Location.GetCities.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "DataModeling\Sql\Procedures\LocationProcedures\Location.GetCitiesByName.sql"

Write-Host "Creating Restaurant procedures..."
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "DataModeling\Sql\Procedures\RestaurantsProcedures\Restaurants.CreateRestaurant.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "DataModeling\Sql\Procedures\RestaurantsProcedures\Restaurants.GetRestaurant.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "DataModeling\Sql\Procedures\RestaurantsProcedures\Restaurants.GetRestaurantReservation.sql"

Write-Host "Creating Report procedures..."
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "DataModeling\Sql\Reports\Agency.CheapestOptions.sql"


Write-Host "Rebuild completed."
Write-Host ""
