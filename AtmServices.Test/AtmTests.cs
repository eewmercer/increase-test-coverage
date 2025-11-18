namespace AtmServices.Test;

using AtmServices;

public class AtmTests

{

    Atm testAtm;

    int initialBalance = 100;

    public AtmTests() {

        testAtm = new Atm(initialBalance);

    }

 

    [Fact]
    public void Test_Withdraw_True()

    {

        var result = testAtm.withdraw(25);

        Assert.True(result);

        Assert.Equal(75, testAtm.getBalance());

    }

    [Fact]
    public void Test_Withdraw_False()

    {

        var result = testAtm.withdraw(150);

        Assert.False(result);

        Assert.Equal(100, testAtm.getBalance());

    }

    [Fact]
    public void Test_Deposit_True()
    {
        var result = testAtm.deposit(50);

        Assert.True(result);

        Assert.Equal(150, testAtm.getBalance());
    }

    [Fact]
    public void Test_Deposit_False()
    {
        var result = testAtm.deposit(-50);

        Assert.False(result);

        Assert.Equal(100, testAtm.getBalance());
    }
}