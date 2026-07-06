import numpy as np

class PsychicAbilities:
    def __init__(self):
        self.abilities = {
            "telepathy": 0.0,
            "telekinesis": 0.0,
            "precognition": 0.0,
            "aura_reading": 0.0
        }
    
    def get_ability_level(self, name: str) -> float:
        return self.abilities.get(name, 0.0)
    
    def train_ability(self, name: str, intensity: float) -> float:
        if name not in self.abilities:
            raise ValueError(f"Unknown ability: {name}")
        gain = np.random.uniform(0.1, 0.5) * intensity
        self.abilities[name] = min(100.0, self.abilities[name] + gain)
        return self.abilities[name]
    
    def get_all_abilities(self) -> dict:
        return dict(self.abilities)