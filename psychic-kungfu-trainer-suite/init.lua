local Trainer = require("trainer.core")
local Game = require("trainer.game")

local PsychicKungFuTrainer = {}

function PsychicKungFuTrainer.new()
    local self = setmetatable({}, { __index = PsychicKungFuTrainer })
    self.trainer = Trainer.new()
    self.game = Game.new()
    return self
end

function PsychicKungFuTrainer:start()
    print("Psychic Kung Fu Master Trainer Suite activated!")
    self.trainer:load_abilities()
    self.game:start_session()
end

return PsychicKungFuTrainer