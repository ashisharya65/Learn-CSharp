// Initializing the CustId properties for CustomerClass and CustomerStruct
CustomerClass cc = new() { CustId = 123 };
CustomerStruct cs = new() { CustId = 123 };

// Prining the value to the console
Console.WriteLine($"CustomerClass CustId before change {cc.CustId}");
Console.WriteLine($"CustomerStruct CustId before change {cs.CustId}");

// Change the value of CustId property from both class and struct using two methods: ChangeCustomerClass & ChangeCustomerStruct 
static void ChangeCustomerStruct(CustomerStruct custs) { custs.CustId = 0; }
static void ChangeCustomerClass(CustomerClass custc) { custc.CustId = 0; }

// Calling both the methods
ChangeCustomerClass(cc);
ChangeCustomerStruct(cs);

// Prining the value to the console
Console.WriteLine($"CustomerClass CustId after change {cc.CustId}");
Console.WriteLine($"CustomerStruct CustId after change {cs.CustId}");

// declaring the struct
struct CustomerStruct
{
    public int CustId { get; set; }
}

// declaring the class
class CustomerClass
{
    public int CustId { get; set; }
}


/*

OUTPUT------------->

CustomerClass CustId before change 123
CustomerStruct CustId before change 123
CustomerClass CustId after change 0
CustomerStruct CustId after change 123

------------------->
Here we can clearly see that CustId property value from CustomerClass is changed to 0 but for struct it is the same.
This clearly proves that the Class is a reference type where the original object was instead of the copy and struct is a value type.
*/

