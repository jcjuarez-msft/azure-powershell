---
external help file:
Module Name: Az.FluidRelay
online version: https://docs.microsoft.com/powershell/module/az.fluidrelay/remove-azfluidrelaycontainer
schema: 2.0.0
---

# Remove-AzFluidRelayContainer

## SYNOPSIS
Delete a Fluid Relay container.

## SYNTAX

### Delete (Default)
```
Remove-AzFluidRelayContainer -FluidRelayServerName <String> -Name <String> -ResourceGroup <String>
 [-SubscriptionId <String>] [-DefaultProfile <PSObject>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### DeleteViaIdentity
```
Remove-AzFluidRelayContainer -InputObject <IFluidRelayIdentity> [-DefaultProfile <PSObject>] [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Delete a Fluid Relay container.

## EXAMPLES

### Example 1: Delete a Fluid Relay container.
```powershell
Remove-AzFluidRelayContainer -FluidRelayServerName azps-fluidrelay -ResourceGroup azpstest-gp -Name eb4dd5f6-531f-44e1-86e3-759d39d1010c
```

Delete a Fluid Relay container.

## PARAMETERS

### -DefaultProfile
The credentials, account, tenant, and subscription used for communication with Azure.

```yaml
Type: System.Management.Automation.PSObject
Parameter Sets: (All)
Aliases: AzureRMContext, AzureCredential

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -FluidRelayServerName
The Fluid Relay server resource name.

```yaml
Type: System.String
Parameter Sets: Delete
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.IFluidRelayIdentity
Parameter Sets: DeleteViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Name
The Fluid Relay container resource name.

```yaml
Type: System.String
Parameter Sets: Delete
Aliases: FluidRelayContainerName

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PassThru
Returns true when the command succeeds

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResourceGroup
The resource group containing the resource.

```yaml
Type: System.String
Parameter Sets: Delete
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SubscriptionId
The subscription id (GUID) for this resource.

```yaml
Type: System.String
Parameter Sets: Delete
Aliases:

Required: False
Position: Named
Default value: (Get-AzContext).Subscription.Id
Accept pipeline input: False
Accept wildcard characters: False
```

### -Confirm
Prompts you for confirmation before running the cmdlet.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: cf

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WhatIf
Shows what would happen if the cmdlet runs.
The cmdlet is not run.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: wi

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.IFluidRelayIdentity

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


INPUTOBJECT <IFluidRelayIdentity>: Identity Parameter
  - `[FluidRelayContainerName <String>]`: The Fluid Relay container resource name.
  - `[FluidRelayServerName <String>]`: The Fluid Relay server resource name.
  - `[Id <String>]`: Resource identity path
  - `[ResourceGroup <String>]`: The resource group containing the resource.
  - `[SubscriptionId <String>]`: The subscription id (GUID) for this resource.

## RELATED LINKS

