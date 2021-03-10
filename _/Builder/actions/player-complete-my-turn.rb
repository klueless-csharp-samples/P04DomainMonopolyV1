DddResourceBuilder.new
  .init
  .resource_key('action:player:complete-my-turn')
  .language(:csharp)
  .template(:action)
  .generate(:overwrite) # options: :write, :overwrite, :diff 
