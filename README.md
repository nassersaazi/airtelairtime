# airtelAirtime api

### Project Goal 

To transition api from node to .net core implementation with minimal api architecture

- This is the initial iteration to show how the project is to be structured by adopting minimal APIs best practices

- The initial idea we had around separating the logic of the controllers from the services is kind of conflicting when we take the minimal api approach. The whole point of using minimal apis is to do away with the complexity of controller-based apis and take advantage of the speed and simplicity of the minimal api approach. 

This is from the microsoft docs

```
 Minimal APIs define endpoints with logical handlers in lambdas or methods, while Controllers-based APIs use classes that derive from ControllerBase1. Minimal APIs are simple and fast, but they lack some features and flexibility of Controllers-based APIs2. Controllers-based APIs are flexible and maintainable, but they require more code and configuration than Minimal APIs
```
 

 ## Todos

[ ] get more clarity on the getAccountBalance route
    - in the nodejs implementation i see the request is made without any parameters. i  was thinking of coming up with an account object but need some more guidance on the best path here. I have left that route out for now pending some clarifications

[ ] add error handling

[ ] parse the xml correctly

[ ] return proper responses with status codes matching the documentation instead of results from the request objects

[ ] add logging to mongodb

[ ] use mongodb instead of inMemory database



