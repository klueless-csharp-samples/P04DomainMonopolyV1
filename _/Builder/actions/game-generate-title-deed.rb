DddResourceBuilder.new
  .init
  .resource_key('action:game:generate-title-deed')
  .language(:csharp)
  .template(:action)
  .generate(:overwrite) # options: :write, :overwrite, :diff 
