# Nancy client

Welcome on Nancy client :)

## Run the solution

You can run the solution directly in Visual studio or 
run `msbuild` inside the solution folder  
This solution has been tested on **VS 2015** and **VS 2017 RC**.

There is a possibility that you need to add an `urlacl` on url `http://+:8080/` 
to be able to listen on that port.

Exception you can encounter:

```
The Nancy self host was unable to start, as no namespace reservation existed for the provided url(s).

Please either enable UrlReservations.CreateAutomatically on the HostConfiguration provided to 
the NancyHost, or create the reservations manually with the (elevated) command(s):

netsh http add urlacl url="http://+:8080/" user="Everyone"
```

In that case run the command below with administrator rights

```powershell
netsh http add urlacl url="http://+:8080/" user="Everyone"
```
