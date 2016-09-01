var target = Argument("target", "Default");

Task("Default")
  .Does(() =>
  {
    Information("It works!");
  });

RunTarget(target);
