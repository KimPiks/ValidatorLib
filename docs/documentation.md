* String *

- Validator.Validate(string).IsEmailAddress();
- Validator.Validate(string).IsPhoneNumber();
- Validator.Validate(string).MinLength(int);
- Validator.Validate(string).MaxLength(int);
- Validator.Validate(string).IsEmpty();
- Validator.Validate(string).IsNotEmpty();
- Validator.Validate(string).Only(CharType);
- Validator.Validate(string).Contains(CharType);

* Int *

- Validator.Validate(int).IsPositive();
- Validator.Validate(int).IsNegative();

* Guid *

- Validator.Validate(Guid).IsEmpty();
- Validator.Validate(Guid).IsNotEmpty();

* Object *

- Validator.Validate(object).IsNull();
- Validator.Validate(object).IsNotNull();