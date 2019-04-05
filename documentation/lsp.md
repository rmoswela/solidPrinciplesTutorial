## Liskov Substitution Principle (LSP)

```
This principle states that derived classes must be substitutable for their base classes.
```

This means that if some function takes a parameter of type **_BaseClass_** then it should be legal to pass in an instance of **_DerivedClass_** to that function as an argument.

#### EXAMPLE

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
_Because it is stupid, ugly, requires work everytime there is a derivative class and most importantly it violates not only the **LSP** but also the **[Open Closed Principle](documentation/ocp.md)**_


### VIOLATIONS OF LSP

Here are some pratical example of **_LSP_** is violated. Find the [code examples here](src/Liskov Substitution Principle)
