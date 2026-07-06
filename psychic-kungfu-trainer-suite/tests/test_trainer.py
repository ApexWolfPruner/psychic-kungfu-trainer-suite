import pytest
from src.trainer import PsychicKungFuTrainer
from src.abilities import PsychicAbilities

def test_trainer_creation():
    trainer = PsychicKungFuTrainer("Master Lee")
    assert trainer.name == "Master Lee"
    assert trainer.energy == 100.0

def test_train_ability():
    trainer = PsychicKungFuTrainer("Student")
    level = trainer.train_ability("telepathy", 2.0)
    assert level > 0.0
    assert level <= 100.0

def test_energy_depletion():
    trainer = PsychicKungFuTrainer("Test")
    for _ in range(12):
        if trainer.energy >= 10:
            trainer.train_ability("telekinesis", 1.0)
    assert trainer.energy < 100.0

def test_meditate():
    trainer = PsychicKungFuTrainer("Zen")
    trainer.energy = 20
    trainer.meditate()
    assert trainer.energy == 50.0

def test_invalid_ability():
    abilities = PsychicAbilities()
    with pytest.raises(ValueError):
        abilities.train_ability("nonexistent", 1.0)

def test_get_status():
    trainer = PsychicKungFuTrainer("Status")
    status = trainer.get_status()
    assert "name" in status
    assert "energy" in status
    assert "abilities" in status