<# .SYNOPSIS
  Connect to with PowerShell with your Azure account
 
 .DESCRIPTION
  Connect to with PowerShell with your Azure account

 .NOTES 
  Requires 
    PowerShell 5.0 or >
    Azure AZ module
    Login to Azure before using it (Connect-Az)
    and chose you subscription (set-azcontext)

    login:
    connect-azaccount     

    list subscription:
    get-azsubscription   
    
    set context to bundlecheck subscription:
    set-azcontext -Subscriptionid 94886bab-8135-4eec-8cb8-fb3889995cec

    module used:
    https://github.com/PlagueHO/CosmosDB#installation

.VARIABLES
    $RgName = name of the resource group
    $CosmosAccount = account name of the cosmos db account
    $CosmosDB = name of the database
    $CollectionName = name of the collection
    $WorkMode = ROOT or PARTNER

   
 .COMPONENT

 .EXAMPLE

 #>
 Connect-AzAccount

 Get-AzSubscription