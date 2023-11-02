
<div align="center"> 
    <h1>Tree Light API </h1>
    
    A Simple API to commicate with a christmas tree running a TreeServer
</div>

## Install ##

### NuGet ###

You can import the API into your project through the command line:

```
> dotnet add package FriendsRobotics.TreeAPI --version 1.0.0
```

Or you can use the NuGet GUI and search for: 

```
FriendsRobotics.TreeAPI
```


## Usage ##

### Configuration ###

Drop a `using` at the start to import the API

```cs
using TreeAPI;
```

To get started, configure your settings 

```cs
// This should be the tree's Ip Address
ConfigManager.IP = "127.0.0.1"; 

// This should be the path you are connecting to.
// Refer to tree-lights/docs if unsure
ConfigMangager.Path = "Text";

// You can usually leave the port out as it will default to 1234
ConfigManager.Port = 1234;
```

Alternatively, you can use `ClientConfig` if you wish to use a config file.

### Connecting to the tree ###

It is easiest to wrap the tree in a `using` statement as it will automatically close the sockets when you are finished.

```cs
using (Tree tree = new Tree()) {
    // Code goes in here
}
```

Now we can connect:

```cs
tree.Connect();
```

_N.B. If you wish to connect to mutliple different paths without having to usee the ConfigManager, there is an `IpAddr` class for you to mess around with_

### Sending some data to the tree ###

Sending data is pretty rudimentary:

```cs
tree.Send("Hello, World!");
```

If you want to capture the response from the tree, there is a `ReceivedMessage` property of the tree.

```cs
Console.WriteLine( tree.ReceivedMessage );
```

### Sending Frames and Animations ###

To send some useful data, you need an `ISendable` object, effectively either a `Frame` or a `Animation`.

```cs
Frame frame = new Frame() {
    // Create your pixels here
}

Animation animation = new Animation() {
    // Create your frames here
}

tree.Send(frame);
tree.Send(animation);
```

Sending either of those will serialize them and send them to the tree to be stored / displayed.







