$path = '/Users/ernsth/Projects/AZURETRAINING/'
$template = './template.json'
$Parameters = './parameters.json'
$Location = 'westeurope'

$RgName = 'AzTrain'
$Tags = @{
    Creator = "Ernst";
    Stage = "Development"
}

$ThisGroup = New-AzResourceGroup -Name $RgName -Location $Location -Tag $Tags

$null = New-AzResourceGroupDeployment -TemplateFile $template -ResourceGroupName $RgName -TemplateParameterFile $Parameters

# New-AzStorageAccount -ResourceGroupName $ThisGroup.ResourceGroupName