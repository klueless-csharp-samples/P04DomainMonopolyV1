DddResourceBuilder.new
  .init
  .resource_key('action:player:sell-building-decision')
  .language(:csharp)
  .template(:action)
  .generate(:overwrite) # options: :write, :overwrite, :diff 
