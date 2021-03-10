DddResourceBuilder.new
  .init
  .resource_key('action:player:buy-unowned-property')
  .language(:csharp)
  .template(:action)
  .generate(:overwrite) # options: :write, :overwrite, :diff 
