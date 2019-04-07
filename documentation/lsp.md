## Liskov Substitution Principle (LSP)

```
This principle states that derived classes must be substitutable for their base classes.
```

This means that if some function takes a parameter of type **_BaseClass_** then it should be legal to pass in an instance of **_DerivedClass_** to that function as an argument.

### Example

Presume that we have a function **_func_** that takes as its parameter a reference to some base class **_BaseClass_**.
Then passed to **_func_** as an argument in the form of **_BaseClass_** is the derivative class **_DerivedClass_**.
The **Liskov Substitution Principle** states that **_func_** should behave exactly like it would if **_BaseClass_** was the argument.
If the behaviour is different then **_LSP_** has been violated.

The code below demonstrates that;

###### *signature*
```
void func (BaseClass& b);
```

###### *correct implementation* ✔️
```
var d = new DerivedClass();

void func (d)
{
  //do something cool
  //without change in behaviour;
}
```

This is how not to do it;
###### *wrong implementation* ❌
```
void func (d)
{
  if (d == some type)
    //do something stupid;
  else if (...)
    //lots of stupidity;
  else
    //infinite stupidity;
}
```

Why is ☝️ wrong?
_Because it is stupid, ugly, requires work everytime there is a derivative class and most importantly it violates not only the **LSP** but also the **[Open Closed Principle](../documentation/ocp.md)**_


### Violations of Liskov Substitution Principle

Here are some pratical example of **_LSP_** when is violated. Find the [code examples here](../src/lsp/violations)

We see that **Shape** has no abstract functions therefore classes **Square** and **Circle** derive from it and both have **_Draw()_** function but don't override **Shape's** **_DrawShape(Shape s)_**.

This means **Circle** and **Square** are not substitutable for **Shape** hence **_DrawShape(Shape s)_** must inspect all **Shape** arguments to determine their _types_ and then call the appropriate **_Draw()_** based on the _type_.

```
- As Square and Circle are not substitutable for Shape they are then violating the LSP.
- Also this violation has force a violation of OCP by the DrawShape().
```
This leads us to;
```
A violation of LSP is in a way a hidden violation of OCP
```

### Lessons from Liskov Substitution Principle
- A model viewed in isolation cannot be meaningfully validated, its validity can only be expressed in terms of its clients/derivatives.
- The principles that guide **LSP** are;
  - Invariants
  - Design By Contract
    - Pre conditions
    - Post conditions
