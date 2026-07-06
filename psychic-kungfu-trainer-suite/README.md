# Psychic Kung Fu Master Trainer Suite

A Python suite for training and tracking psychic kung fu abilities.

## Installation

```bash
pip install -r requirements.txt
```

## Usage

```python
from trainer import PsychicKungFuTrainer
from abilities import PsychicAbilities

trainer = PsychicKungFuTrainer("Master Lee")
trainer.train_ability("telepathy", 10)
print(trainer.get_status())
```