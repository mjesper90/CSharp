public Classes with PascalCase

```cs
public class Pascal{

};
```


public/protected fields with PascalCase

```cs
public string Pascal = "Pascal";
```

Private fields with underscore camelCase

```cs
private int _camelCase = 0;
```

public/protected Methods with PascalCase
```cs
public void PublicMethod(){
    //Method definition
};
```

private/internal Methods camelCase
```cs
private void privateMethod(){
    //Method definition
};
```

method parameters with camelCase
```cs
public void ParamaterizedMethod(string thisIsParamaterOne, int hello, float value){
    //Method definition
};

```

local scoped variables with camelCase

```cs
public class Example{
    public Example(){
        int thisIsanExample;
    }
};

```


```cs
public class FullExample{

    public string MyPublicStringField = "Hi";
    protected string MyProtectedStringField = "Hi";
    private string _myPrivateStringField = "Hi";
    internal string _myInternalStringField = "Hi";

    public FullExample(){
        //Constructor definition
        checkDependencies();
    }

    public int Add(int firstNumber, int secondNumber){
        int localVariable = firstNumber + secondNumber;
        return localVariable;
    }

    private void checkDependencies(){
        //Method definition
    }
}
```
