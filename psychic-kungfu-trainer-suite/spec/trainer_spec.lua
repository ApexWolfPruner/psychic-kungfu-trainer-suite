local Trainer = require("trainer.core")
local Ability = require("trainer.ability")

describe("Psychic Kung Fu Trainer", function()
    local trainer

    before_each(function()
        trainer = Trainer.new()
    end)

    it("should load abilities", function()
        trainer:load_abilities()
        assert.is_equal(3, #trainer.abilities)
    end)

    it("should find ability by name", function()
        trainer:load_abilities()
        local ability = trainer:get_ability("Telekinesis")
        assert.is_equal("Telekinesis", ability.name)
    end)
end)