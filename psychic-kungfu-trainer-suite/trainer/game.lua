local Game = {}

function Game.new()
    local self = setmetatable({}, { __index = Game })
    self.session_active = false
    return self
end

function Game:start_session()
    self.session_active = true
    print("Training session started. Focus your chi!")
end

function Game:end_session()
    self.session_active = false
    print("Session ended. Rest and meditate.")
end

return Game