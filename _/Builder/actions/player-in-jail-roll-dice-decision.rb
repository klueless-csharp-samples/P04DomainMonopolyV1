DddResourceBuilder.new
  .init
  .resource_key('action:player:in-jail-roll-dice-decision')
  .language(:csharp)
  .template(:action)
  .generate(:overwrite) # options: :write, :overwrite, :diff 
