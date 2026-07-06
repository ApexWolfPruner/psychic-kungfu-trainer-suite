local Ability = require("trainer.ability")

local Trainer = {}

function Trainer.new()
    local self = setmetatable({}, { __index = Trainer })
    self.abilities = {}
    return self
end

function Trainer:load_abilities()
    self.abilities = {
        Ability.new("Telekinesis", 50),
        Ability.new("Precognition", 30),
        Ability.new("Aura Strike", 70)
    }
    print("Loaded " .. #self.abilities .. " psychic abilities.")
end

function Trainer:get_ability(name)
    for _, ability in ipairs(self.abilities) do
        if ability.name == name then
            return ability
        end
    end
    return nil
end

return Trainer