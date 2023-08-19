# UnitTesting
## Good unit tests
- First class citizens
- Clean, Readable and maintainable
- No logic
- Isolated
- Not too specific or general
## What to test what not to test
- Testable code is clean
- Clean code is testable
- Test the outcome of a function
- Test all the execution paths
- Query functions => return some values, verify the function return the exact value.
- Command functions => performs an action, change the state of the system. Need to verify the value as well as the state of the system.
- Do not test => language features and 3rd party libraries only the code you wrote
## Naming and organizing tests  
- Project => Project.UnitTests
- Class => Class.UnitTests
- Number of tests >= Number of execution paths
- Name of a test method => methodName_scenario_outcome
- a class have more methods then write class_methodNameTests separate class per method
## SetUp and TearDown
## Parameterized Tests

  
