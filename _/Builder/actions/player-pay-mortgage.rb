DddResourceBuilder.new
  .init
  .resource_key('action:player:pay-mortgage')
  .language(:csharp)
  .template(:action)
  .generate(:overwrite) # options: :write, :overwrite, :diff 
