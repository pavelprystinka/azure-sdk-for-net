# Azure.Communication.PhoneNumbers

Run `dotnet msbuild /t:GenerateCode` to generate code.

### AutoRest Configuration
> see https://aka.ms/autorest

``` yaml
public-clients: true
input-file:
    -  https://github.com/pavelprystinka/azure-rest-api-specs/blob/36ee467b56f23156015869ad7047e9193636895a/specification/communication/data-plane/Microsoft.CommunicationServicesPhoneNumbers/stable/2021-03-07/phonenumbers.json
title: Phone numbers
payload-flattening-threshold: 3
```
