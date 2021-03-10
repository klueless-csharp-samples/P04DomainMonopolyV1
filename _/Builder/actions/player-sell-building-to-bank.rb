DddResourceBuilder.new
  .init
  .resource_key('action:player:sell-building-to-bank')
  .language(:csharp)
  .template(:action)
  .generate(:overwrite) # options: :write, :overwrite, :diff 
