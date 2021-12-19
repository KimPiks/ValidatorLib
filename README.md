
# ValidatorLib

A simple library for data validation.
## Documentation

[Documentation](https://github.com/KimPiks/ValidatorLib/tree/main/docs)

  
## Installation

Validation Lib can be installed using one of these commands

```bash
PM> Install-Package ValidatorLib
```
```bash
> dotnet add package ValidatorLib
```

## Tests and benchmarks

Tests and benchmarks can be found in [/src/tests/](https://github.com/KimPiks/ValidatorLib/tree/main/src/tests)
  
## License

[MIT](https://github.com/KimPiks/ValidatorLib/blob/main/License.txt)

  
## Usage/Examples

```c#
var str = "example@email.com";
try
{
    Validator.Validate(str).IsEmailAddress();
    Validator.Validate(str).MinLength(8);
    Validator.Validate(str).IsNotEmpty();
}
catch (ArgumentException e)
{
    // If an exception is thrown, the string is not valid
}
```

```c#
var str = "example@email.com";
try
{
    var validator = new CustomValidator<string>();
    
    validator.AddRule(x => Validator.Validate(x).IsEmailAddress());
    validator.AddRule(x => Validator.Validate(x).MinLength(8));
    validator.AddRule(x => Validator.Validate(x).IsNotEmpty());

    validator.Validate(str);
}
catch (ArgumentException e)
{
    // If an exception is thrown, the string is not valid
}
```

For more examples let's see [/examples/](https://github.com/K1mP1x/ValidatorLib/tree/main/examples)
  
## Support

For support, email kamilxprorok@gmail.com

  
## Feedback

If you have any feedback, please reach out to me at kamilxprorok@gmail.com

  
## Authors

- [@KimPix](https://github.com/KimPiks)

  
## Contributing

Contributions are always welcome!

Remember to edit README.md and documentation.md

1. Fork the repo on GitHub
2. Clone the project to your own machine
3. Commit changes to your own branch
4. Push your work back up to your fork
5. Submit a Pull request so that we can review your changes
