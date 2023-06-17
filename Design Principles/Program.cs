using Design_Principles;

Dry.Violation("Yo");
List<string> msg = new List<string>();
msg.Add("Hello");
msg.Add("World");
Dry.Compliance(msg);