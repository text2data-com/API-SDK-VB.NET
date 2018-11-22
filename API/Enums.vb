
Public Enum DocumentResultStatus
    OK = 1
    AuthenticationFailure = 2
    CreditExceeded = 3 'top up required
    ServiceBusy = 4
    ValidationError = 5
    GenericError = 6
End Enum

Public Enum SerializeFormats
    Json = 1
    Xml = 2
End Enum