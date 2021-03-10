DddResourceBuilder.new
  .init
  .resource_key('action:player:roll-dice')
  .language(:csharp)
  .template(:action)
  .generate(:overwrite) # options: :write, :overwrite, :diff 
