local Ability = {}

function Ability.new(name, power)
    local self = setmetatable({}, { __index = Ability })
    self.name = name
    self.power = power
    return self
end

function Ability:activate()
    return string.format("%s activated! Power: %d", self.name, self.power)
end

return Ability