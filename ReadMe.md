This is MicroService template created based on following assumptions:
1. Using IIS instead of windows service/Webjob

IN the Api project
Bootstrapper
* Business Models,	the models that has business meanings, for example request and response models
* Enumerations,		storing all enumerations
* Extensions,		for extension classes
* Helpers,			helper classes that would be use in the microservice, for example special string operation class
* Models,			Non-business models, such as DTOs, context, etc
* Modules,			Nancy module layer, mainly for API routing
* Resources,		for resource mapping, for example mapping between errorcode and error descriptions
* Services,			business logic layer
* Validation,		validation class that use for data inbound validation.

The system is can be considered as following layers:

1. Modules layer, for API routing
2. Service layer, For business logic
3. Data access layer, Entity Framework