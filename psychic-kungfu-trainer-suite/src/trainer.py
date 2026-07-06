from .abilities import PsychicAbilities

class PsychicKungFuTrainer:
    def __init__(self, name: str):
        self.name = name
        self.abilities = PsychicAbilities()
        self.energy = 100.0
    
    def train_ability(self, ability: str, intensity: float = 1.0) -> float:
        if self.energy < 10:
            raise RuntimeError("Not enough energy to train")
        self.energy -= 10 * intensity
        return self.abilities.train_ability(ability, intensity)
    
    def meditate(self) -> None:
        self.energy = min(100.0, self.energy + 30)
    
    def get_status(self) -> dict:
        return {
            "name": self.name,
            "energy": self.energy,
            "abilities": self.abilities.get_all_abilities()
        }