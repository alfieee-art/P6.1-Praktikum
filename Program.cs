var manager = new GameManager();
manager.Spawn(new Warrior { Name = "Aldric" });
manager.Spawn(new Mage { Name = "Elara" });
manager.Spawn(new Archer { Name = "Rin" });
manager.Spawn(new Warrior { Name = "Borin" });
manager.Spawn(new Assassin { Name = "Lukas" });
manager.Spawn(new Healer { Name = "Estes" });

manager.UpdateFrame();