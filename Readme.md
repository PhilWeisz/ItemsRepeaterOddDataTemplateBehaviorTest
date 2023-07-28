# ItemsRepeaterOddDataTemplateBehaviorTest

This repository demonstrates an issue with an `InvalidCastException` that occurs when using the `View` directly inside the `ItemRepeaterElement-Item-/Data-Template`, rather than the `ContentControl`.

![InvalidCastException](ExampleImage/InvalidCastException.png)

The image above showcases the exception occuring - but the Project builds and runs nevertheless.

## To replicate

1. Clone this repository to your local machine.
2. Open the solution in Visual Studio.
3. Build and run the solution to reproduce the `InvalidCastException`.


